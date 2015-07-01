using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpLewtz;
using System.Windows.Forms;

namespace SharpLewtz
{
    class ItemDirector
    {
        LootTable bfrTypeTable = new LootTable();
        public void Construct(ItemBuilder ib, string rank)
        {
            switch(rank.ToLower())
            {
                case "minor":
                    bfrTypeTable = Form1.MinorMagicType;
                    break;
                case "medium":
                    bfrTypeTable = Form1.MediumMagicType;
                    break;
                case "major":
                    bfrTypeTable = Form1.MajorMagicType;
                    break;
            }

            ib.RollType(bfrTypeTable);
            ib.BuildBonus();
            ib.SetCost();
            ib.GetMagicItem();
        }
    }

    abstract class ItemBuilder
    {
        public abstract void RollType(LootTable typeTable);
        public abstract void BuildBonus();
        public abstract void SetCost();
        public abstract Item GetMagicItem();
    }

    class ConcreteItemBuilder : ItemBuilder
    {
        Item bufferItem = new Item();
        
        public override void RollType(LootTable typeTable)
        {
            //roll on the table to return the BASE item (IE Dagger/Chainmail/Penis Protector/etc)
            try
            {
                bufferItem = typeTable.Results.Single();

                if(bufferItem.Type == (ItemType.Armor | ItemType.Magic))
                {
                    bufferItem = Form1.ArmorTable.Results.Single();
                }
                if(bufferItem.Type == (ItemType.Weapon | ItemType.Magic))
                {
                    bufferItem = Form1.WeaponsTable.Results.Single();
                }
                //either hard code this or add another loaded table for the weapons/armors/etc. This shit won't work.
            }
            catch(Exception e)
            {
                MessageBox.Show("There is more than one possible result in your buffer! FIX IT BITCH. " + e);
            }
        }

        public override void BuildBonus()
        {
            
            LootTable bonusTable = new LootTable();
            LootTable abilityTable = new LootTable();

            //MessageBox.Show("Bonus is being built!");
            int rollsLeft = 0;
            
            ItemType itemType = (ItemType)(bufferItem.Type - (((bufferItem.Type & ItemType.Magic) == ItemType.Magic) ? ItemType.Magic : 0)); //all of these will be magic, no need to check it
            switch (itemType)
            //THIS SOMEHOW BECOMES ABILITY AND FUCKS SHIT UP. FIX IT. BITCH.
            //{
                case ItemType.Armor:
                    bonusTable = Form1.MinorArmorTable;
                    abilityTable = Form1.MinorArmorAbilities;
                    //MessageBox.Show("Armor: " + bufferItem.ToString());
                    break;
                case ItemType.Shield:
                    bonusTable = Form1.MinorArmorAbilities;
                    abilityTable = Form1.MinorShieldAbilities;
                   //MessageBox.Show("Shield: " + bufferItem.ToString());
                    break;
                case ItemType.Melee_Weapon:
                    bonusTable = Form1.MinorWeaponTable;
                    abilityTable = Form1.MinorMeleeWeaponAbilities;
                    //MessageBox.Show("Melee Weapon: " + bufferItem.ToString());
                    break;
                case ItemType.Ranged_Weapon:
                    bonusTable = Form1.MinorWeaponTable;
                    abilityTable = Form1.MinorRangedWeaponAbilities;
                    break;
                case ItemType.Potion:
                    bonusTable = Form1.MinorPotionTable;
                    break;
                case ItemType.Ring:
                    bonusTable = Form1.MinorRingTable;
                    break;
                case ItemType.Rod:
                    bonusTable = Form1.MinorRodTable;
                    break;
                case ItemType.Scroll:
                    bonusTable = Form1.MinorScrollTable;
                    break;
                case ItemType.Wand:
                    bonusTable = Form1.MinorWandTable;
                    break;
                case ItemType.Wondrous:
                    bonusTable = Form1.MinorWondrousItemTable;
                    break;
                default:
                    MessageBox.Show("You shouldn't have this... " + (int)bufferItem.Type + " integer: " + (int)bufferItem.Type);
                    bonusTable = Form1.MinorWondrousItemTable;
                    break;
            }

            do
            {
                try
                {
                    //ITEM HAS BEEN ROLLED, next do the abilities/bonuses

                    var bufferType = bonusTable.Results.Single();
                    bufferType.Type = ItemType.Ability;
                    if(bufferType.Type == ItemType.Ability)
                    {
                        bufferItem.AddAbility(bufferType);
                        //++rollsLeft;
                        //MessageBox.Show("Abilties!!! : ");
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show("FUUUUUUUUUUUUUUUUUUUUUpenis " + e);//bufferItem.ToString());
                }

            } while (rollsLeft > 0);
            
            //Roll to determine bonus (+1,+2, abilities, etc)
        }

        public override void SetCost()
        {
            //MessageBox.Show("Cost is being set!");
            //set the dynamic cost, including all abilities and bonuses
        }

        public override Item GetMagicItem()
        {
            MessageBox.Show(bufferItem.ToString());
            return bufferItem;
            //will i use this? who knows. Yes. Yes I will.
        }
    }
}
