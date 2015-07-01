using SharpLewtz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpLewtz
{
    public partial class Form1
    {
        public static LootTable TreasureTable = new LootTable();

        public static LootTable MundaneItemsTable = new LootTable();

            public static LootTable AlchemicalItemsTable = new LootTable("Tables\\Alchemical Items.Lewt", type: ItemType.Alchemical);

            public static LootTable ArmorTable = new LootTable("Tables\\Common Armors.Lewt", type: ItemType.Armor);
                public static LootTable DarkwoodShields = new LootTable();

            public static LootTable Shields = new LootTable("Tables\\Common Shields.Lewt", type: ItemType.Shield);

            public static LootTable WeaponsTable = new LootTable();
                public static LootTable CommonWeapons = new LootTable(      "Tables\\Common Melee Weapons.Lewt",  type: ItemType.Melee_Weapon);
                public static LootTable UncommonWeapons = new LootTable(    "Tables\\DMG Uncommon Weapons.Lewt",  type: ItemType.Melee_Weapon);
                public static LootTable CommonRangedWeapons = new LootTable("Tables\\Common Ranged Weapons.Lewt", type: ItemType.Ranged_Weapon);

            public static LootTable ToolsGear = new LootTable("Tables\\ToolsGear.lewt", type: (ItemType.Tool | ItemType.Salvage));


        #region minor magic declaration
        public static LootTable MinorMagicType = new LootTable();

        public static LootTable MinorArmorTable = new LootTable();
            public static LootTable MinorSpecificArmors = new LootTable();
            public static LootTable MinorSpecificShields = new LootTable();

            public static LootTable MinorArmorAbilities = new LootTable( "Tables\\DMG Armor Special Abilities.Lewt",  type: (ItemType.Magic | ItemType.Armor  | ItemType.Ability));
            public static LootTable MinorShieldAbilities = new LootTable("Tables\\DMG Shield Special Abilities.Lewt", type: (ItemType.Magic | ItemType.Shield | ItemType.Ability));


        public static LootTable MinorWeaponTable = new LootTable();
            public static LootTable MinorSpecificWeapons = new LootTable();

            public static LootTable MinorMeleeWeaponAbilities = new LootTable( "Tables\\DMG Melee Weapon Special Abilities.Lewt",  type: (ItemType.Magic | ItemType.Melee_Weapon  | ItemType.Ability));
            public static LootTable MinorRangedWeaponAbilities = new LootTable("Tables\\DMG Ranged Weapon Special Abilities.Lewt", type: (ItemType.Magic | ItemType.Ranged_Weapon | ItemType.Ability));

        public static LootTable MinorPotionTable = new LootTable();
        public static LootTable MinorRingTable = new LootTable();
        public static LootTable MinorScrollTable = new LootTable();
        public static LootTable MinorWandTable = new LootTable();
        public static LootTable MinorRodTable = new LootTable();
        public static LootTable MinorWondrousItemTable = new LootTable();

        #endregion

        #region Medium Magic Declarations
        public static LootTable MediumMagicType = new LootTable();

        public static LootTable MediumArmorTable = new LootTable();
            public static LootTable MediumSpecificArmors = new LootTable();
            public static LootTable MediumSpecificShields = new LootTable();

            public static LootTable MediumArmorAbilities = new LootTable( "Tables\\DMG Armor Special Abilities.Lewt",  type: (ItemType.Magic | ItemType.Armor  | ItemType.Ability), rank: 1);
            public static LootTable MediumShieldAbilities = new LootTable("Tables\\DMG Shield Special Abilities.Lewt", type: (ItemType.Magic | ItemType.Shield | ItemType.Ability), rank: 1);


        public static LootTable MediumWeaponTable = new LootTable();
            public static LootTable MediumSpecificWeapons = new LootTable();

            public static LootTable MediumMeleeWeaponAbilities = new LootTable( "Tables\\DMG Melee Weapon Special Abilities.Lewt",  type: (ItemType.Magic | ItemType.Melee_Weapon  | ItemType.Ability), rank: 1);
            public static LootTable MediumRangedWeaponAbilities = new LootTable("Tables\\DMG Ranged Weapon Special Abilities.Lewt", type: (ItemType.Magic | ItemType.Ranged_Weapon | ItemType.Ability), rank: 1);

        public static LootTable MediumPotionTable = new LootTable();
        public static LootTable MediumRingTable = new LootTable();
        public static LootTable MediumRodTable = new LootTable();
        public static LootTable MediumScrollTable = new LootTable();
        public static LootTable MediumWandTable = new LootTable();
        public static LootTable MediumStaffTable = new LootTable();
        public static LootTable MediumWondrousItemTable = new LootTable();

        #endregion

        #region Major Magic Declarations
        public static LootTable MajorMagicType = new LootTable();

        public static LootTable MajorArmorTable = new LootTable();
            public static LootTable MajorSpecificArmors = new LootTable();
            public static LootTable MajorSpecificShields = new LootTable();

            public static LootTable MajorArmorAbilities = new LootTable( "Tables\\DMG Armor Special Abilities.Lewt",  type: (ItemType.Magic | ItemType.Armor  | ItemType.Ability), rank: 2);
            public static LootTable MajorShieldAbilities = new LootTable("Tables\\DMG Shield Special Abilities.Lewt", type: (ItemType.Magic | ItemType.Shield | ItemType.Ability), rank: 2);


        public static LootTable MajorWeaponTable = new LootTable();
            public static LootTable MajorSpecificWeapons = new LootTable();

            public static LootTable MajorMeleeWeaponAbilities = new LootTable( "Tables\\DMG Melee Weapon Special Abilities.Lewt",  type: (ItemType.Magic | ItemType.Melee_Weapon  | ItemType.Ability), rank: 2);
            public static LootTable MajorRangedWeaponAbilities = new LootTable("Tables\\DMG Ranged Weapon Special Abilities.Lewt", type: (ItemType.Magic | ItemType.Ranged_Weapon | ItemType.Ability), rank: 2);

        public static LootTable MajorPotionTable = new LootTable();
        public static LootTable MajorRingTable = new LootTable();
        public static LootTable MajorRodTable = new LootTable();
        public static LootTable MajorScrollTable = new LootTable();
        public static LootTable MajorWandTable = new LootTable();
        public static LootTable MajorStaffTable = new LootTable();
        public static LootTable MajorWondrousItemTable = new LootTable();

        #endregion

        public static void LoadTables()
        {
            
            #region Mundane Items Table

                MundaneItemsTable.AddEntry(AlchemicalItemsTable, 17);

                MundaneItemsTable.AddEntry(ArmorTable, 50);
                    ArmorTable.AddEntry(DarkwoodShields, 90);
                        DarkwoodShields.AddEntry(new Item("Darkwood Buckler", 20500, type: ItemType.Shield), 50);
                        DarkwoodShields.AddEntry(new Item("Darkwood Shield",  25700, type: ItemType.Shield), 100);

                    ArmorTable.AddEntry(Shields, 100);

                MundaneItemsTable.AddEntry(WeaponsTable, 83);
                    WeaponsTable.AddEntry(CommonWeapons, 70);
                    WeaponsTable.AddEntry(UncommonWeapons, 80);
                    WeaponsTable.AddEntry(CommonRangedWeapons, 100);

                MundaneItemsTable.AddEntry(ToolsGear, 100);
            #endregion

            #region Minor Magic Table

            MinorMagicType.AddEntry(new Item(type:  (ItemType.Magic | ItemType.Armor)), 4);
            MinorMagicType.AddEntry(new Item(type:  (ItemType.Magic | ItemType.Weapon)), 9);

            MinorMagicType.AddEntry(MinorPotionTable, 44);
                MinorPotionTable.AddEntry(new Item("Potion 1", type: (ItemType.Magic | ItemType.Potion)), 25);
                MinorPotionTable.AddEntry(new Item("Potion 2", type: (ItemType.Magic | ItemType.Potion)), 65);
                MinorPotionTable.AddEntry(new Item("Potion 3", type: (ItemType.Magic | ItemType.Potion)), 100);

            MinorMagicType.AddEntry(MinorRingTable, 46);
                MinorRingTable.AddEntry(new Item("Ring 1", type: (ItemType.Magic | ItemType.Ring)), 25);
                MinorRingTable.AddEntry(new Item("Ring 2", type: (ItemType.Magic | ItemType.Ring)), 65);
                MinorRingTable.AddEntry(new Item("Ring 3", type: (ItemType.Magic | ItemType.Ring)), 100);

            MinorMagicType.AddEntry(MinorScrollTable, 81);
                MinorScrollTable.AddEntry(new Item("Scroll 1", type: (ItemType.Magic | ItemType.Scroll)), 25);
                MinorScrollTable.AddEntry(new Item("Scroll 2", type: (ItemType.Magic | ItemType.Scroll)), 65);
                MinorScrollTable.AddEntry(new Item("Scroll 3", type: (ItemType.Magic | ItemType.Scroll)), 100);

            MinorMagicType.AddEntry(MinorWandTable, 91);
                MinorWandTable.AddEntry(new Item("Wand 1", type: (ItemType.Magic | ItemType.Wand)), 25);
                MinorWandTable.AddEntry(new Item("Wand 2", type: (ItemType.Magic | ItemType.Wand)), 65);
                MinorWandTable.AddEntry(new Item("Wand 3", type: (ItemType.Magic | ItemType.Wand)), 100);

            MinorMagicType.AddEntry(MinorWondrousItemTable, 100);
                MinorWondrousItemTable.AddEntry(new Item("Wondrous Item 1", type: (ItemType.Magic | ItemType.Wondrous)), 25);
                MinorWondrousItemTable.AddEntry(new Item("Wondrous Item 2", type: (ItemType.Magic | ItemType.Wondrous)), 65);
                MinorWondrousItemTable.AddEntry(new Item("Wondrous Item 3", type: (ItemType.Magic | ItemType.Wondrous)), 100);


            MinorArmorTable.AddEntry(new Item("+1", cost: 1, type: (ItemType.Magic | ItemType.Armor)), 60);
            MinorArmorTable.AddEntry(new Item("+1", cost: 1, type: (ItemType.Magic | ItemType.Shield)), 80);
            MinorArmorTable.AddEntry(new Item("+2", cost: 2, type: (ItemType.Magic | ItemType.Armor)), 85);
            MinorArmorTable.AddEntry(new Item("+2", cost: 2, type: (ItemType.Magic | ItemType.Shield)), 87);
                
            MinorArmorTable.AddEntry(MinorSpecificArmors, 89);
                MinorSpecificArmors.AddEntry(new Item("ARMOR, BITCH!", type: (ItemType.Magic | ItemType.Armor)), always: true);
            MinorArmorTable.AddEntry(MinorSpecificShields, 91);
                MinorSpecificShields.AddEntry(new Item("SHIELD, BITCH!", type: (ItemType.Magic | ItemType.Shield)), always: true);

            MinorArmorTable.AddEntry(new Item("Ability", type: (ItemType.Magic | ItemType.Ability)), 100); //special abilites. ROLL AGAIN


            MinorWeaponTable.AddEntry(new Item("+1", cost: 1, type: (ItemType.Magic | ItemType.Weapon)), 70);
            MinorWeaponTable.AddEntry(new Item("+2", cost: 2, type: (ItemType.Magic | ItemType.Weapon)), 85);

            MinorWeaponTable.AddEntry(MinorSpecificWeapons, 90);
                MinorSpecificWeapons.AddEntry(new Item("WEAPON, BITCH!", type: (ItemType.Magic | ItemType.Weapon)), always: true);

            MinorWeaponTable.AddEntry(new Item("Ability", type: (ItemType.Magic | ItemType.Ability)), 100);


            #endregion

            #region Medium Magic Table


                #region Armor
                MediumMagicType.AddEntry(MediumArmorTable, 10);
                    MediumArmorTable.AddEntry(new Item("+1", cost: 1, type: (ItemType.Magic | ItemType.Armor)), 5);
                    MediumArmorTable.AddEntry(new Item("+1", cost: 1, type: (ItemType.Magic | ItemType.Shield)), 10);
                    MediumArmorTable.AddEntry(new Item("+2", cost: 2, type: (ItemType.Magic | ItemType.Armor)), 20);
                    MediumArmorTable.AddEntry(new Item("+2", cost: 2, type: (ItemType.Magic | ItemType.Shield)), 30);
                    MediumArmorTable.AddEntry(new Item("+3", cost: 3, type: (ItemType.Magic | ItemType.Armor)), 40);
                    MediumArmorTable.AddEntry(new Item("+3", cost: 3, type: (ItemType.Magic | ItemType.Shield)), 50);
                    MediumArmorTable.AddEntry(new Item("+4", cost: 4, type: (ItemType.Magic | ItemType.Armor)), 55);
                    MediumArmorTable.AddEntry(new Item("+4", cost: 4, type: (ItemType.Magic | ItemType.Shield)), 57);

                    MediumArmorTable.AddEntry(MediumSpecificArmors, 60);
                    MediumArmorTable.AddEntry(MediumSpecificShields, 63);

                    MediumArmorTable.AddEntry(new Item("Ability", type: (ItemType.Magic | ItemType.Ability)), 100); //special abilites. ROLL AGAIN
                #endregion

                #region Weapons
                MediumMagicType.AddEntry(MediumWeaponTable, 9);
                    MediumWeaponTable.AddEntry(new Item("+1", cost: 1, type: (ItemType.Magic | ItemType.Melee_Weapon | ItemType.Ranged_Weapon)), 10);
                    MediumWeaponTable.AddEntry(new Item("+2", cost: 2, type: (ItemType.Magic | ItemType.Melee_Weapon | ItemType.Ranged_Weapon)), 29);
                    MediumWeaponTable.AddEntry(new Item("+3", cost: 3, type: (ItemType.Magic | ItemType.Melee_Weapon | ItemType.Ranged_Weapon)), 58);
                    MediumWeaponTable.AddEntry(new Item("+4", cost: 4, type: (ItemType.Magic | ItemType.Melee_Weapon | ItemType.Ranged_Weapon)), 62);

                    MediumWeaponTable.AddEntry(MediumSpecificWeapons, 68);

                    MediumWeaponTable.AddEntry(new Item("Ability", type: (ItemType.Magic | ItemType.Ability)), 100);
                #endregion

                #region Pots and shit
                MediumMagicType.AddEntry(MediumPotionTable, 30);
                    MediumPotionTable.AddEntry(new Item("Potion 1", type: (ItemType.Magic | ItemType.Potion)), 25);
                    MediumPotionTable.AddEntry(new Item("Potion 2", type: (ItemType.Magic | ItemType.Potion)), 65);
                    MediumPotionTable.AddEntry(new Item("Potion 3", type: (ItemType.Magic | ItemType.Potion)), 100);

                MediumMagicType.AddEntry(MediumRingTable, 40);
                    MediumRingTable.AddEntry(new Item("Ring 1", type: (ItemType.Magic | ItemType.Ring)), 25);
                    MediumRingTable.AddEntry(new Item("Ring 2", type: (ItemType.Magic | ItemType.Ring)), 65);
                    MediumRingTable.AddEntry(new Item("Ring 3", type: (ItemType.Magic | ItemType.Ring)), 100);

                MediumMagicType.AddEntry(MediumRodTable, 50);
                    MediumRodTable.AddEntry(new Item("Rod 1", type: (ItemType.Magic | ItemType.Rod)), 25);
                    MediumRodTable.AddEntry(new Item("Rod 1", type: (ItemType.Magic | ItemType.Rod)), 65);
                    MediumRodTable.AddEntry(new Item("Rod 1", type: (ItemType.Magic | ItemType.Rod)), 100);

                MediumMagicType.AddEntry(MediumScrollTable, 65);
                    MediumScrollTable.AddEntry(new Item("Scroll 1", type: (ItemType.Magic | ItemType.Scroll)), 25);
                    MediumScrollTable.AddEntry(new Item("Scroll 2", type: (ItemType.Magic | ItemType.Scroll)), 65);
                    MediumScrollTable.AddEntry(new Item("Scroll 3", type: (ItemType.Magic | ItemType.Scroll)), 100);

                MediumMagicType.AddEntry(MediumStaffTable, 68);
                    MediumStaffTable.AddEntry(new Item("Staff 1", type: (ItemType.Magic | ItemType.Staff)), 25);
                    MediumStaffTable.AddEntry(new Item("Staff 2", type: (ItemType.Magic | ItemType.Staff)), 65);
                    MediumStaffTable.AddEntry(new Item("Staff 3", type: (ItemType.Magic | ItemType.Staff)), 100);

                MediumMagicType.AddEntry(MediumWandTable, 83);
                    MediumWandTable.AddEntry(new Item("Wand 1", type: (ItemType.Magic | ItemType.Wand)), 25);
                    MediumWandTable.AddEntry(new Item("Wand 2", type: (ItemType.Magic | ItemType.Wand)), 65);
                    MediumWandTable.AddEntry(new Item("Wand 3", type: (ItemType.Magic | ItemType.Wand)), 100);

                MediumMagicType.AddEntry(MediumWondrousItemTable, 100);
                    MediumWondrousItemTable.AddEntry(new Item("Wondrous Item 1", type: (ItemType.Magic | ItemType.Wondrous)), 25);
                    MediumWondrousItemTable.AddEntry(new Item("Wondrous Item 2", type: (ItemType.Magic | ItemType.Wondrous)), 65);
                    MediumWondrousItemTable.AddEntry(new Item("Wondrous Item 3", type: (ItemType.Magic | ItemType.Wondrous)), 100);
                #endregion

            #endregion

            #region Major Magic Table
            
            #region Armor
            MajorMagicType.AddEntry(MajorArmorTable, 10);
                MajorArmorTable.AddEntry(new Item("+3", cost: 3, type: (ItemType.Magic | ItemType.Armor)), 8);
                MajorArmorTable.AddEntry(new Item("+3", cost: 3, type: (ItemType.Magic | ItemType.Shield)), 16);
                MajorArmorTable.AddEntry(new Item("+4", cost: 4, type: (ItemType.Magic | ItemType.Armor)), 27);
                MajorArmorTable.AddEntry(new Item("+4", cost: 4, type: (ItemType.Magic | ItemType.Shield)), 38);
                MajorArmorTable.AddEntry(new Item("+5", cost: 5, type: (ItemType.Magic | ItemType.Armor)), 49);
                MajorArmorTable.AddEntry(new Item("+5", cost: 5, type: (ItemType.Magic | ItemType.Shield)), 57);

                MajorArmorTable.AddEntry(MajorSpecificArmors, 60);
                MajorArmorTable.AddEntry(MajorSpecificShields, 63);

                MajorArmorTable.AddEntry(new Item("Ability", type: (ItemType.Magic | ItemType.Ability)), 100); //special abilites. ROLL AGAIN
            #endregion

            #region Weapons
            MajorMagicType.AddEntry(MajorWeaponTable, 20);
                MajorWeaponTable.AddEntry(new Item("+3", cost: 1, type: (ItemType.Magic | ItemType.Melee_Weapon | ItemType.Ranged_Weapon)), 20);
                MajorWeaponTable.AddEntry(new Item("+4", cost: 2, type: (ItemType.Magic | ItemType.Melee_Weapon | ItemType.Ranged_Weapon)), 38);
                MajorWeaponTable.AddEntry(new Item("+5", cost: 3, type: (ItemType.Magic | ItemType.Melee_Weapon | ItemType.Ranged_Weapon)), 49);

                MajorWeaponTable.AddEntry(MajorSpecificWeapons, 63);

                MajorWeaponTable.AddEntry(new Item("Ability", type: (ItemType.Magic | ItemType.Ability)), 100);
            #endregion

            #region Pots and shit
            MajorMagicType.AddEntry(MajorPotionTable, 25);
                MajorPotionTable.AddEntry(new Item("Potion 1", type: (ItemType.Magic | ItemType.Potion)), 25);
                MajorPotionTable.AddEntry(new Item("Potion 2", type: (ItemType.Magic | ItemType.Potion)), 65);
                MajorPotionTable.AddEntry(new Item("Potion 3", type: (ItemType.Magic | ItemType.Potion)), 100);

            MajorMagicType.AddEntry(MajorRingTable, 35);
                MajorRingTable.AddEntry(new Item("Ring 1", type: (ItemType.Magic | ItemType.Ring)), 25);
                MajorRingTable.AddEntry(new Item("Ring 2", type: (ItemType.Magic | ItemType.Ring)), 65);
                MajorRingTable.AddEntry(new Item("Ring 3", type: (ItemType.Magic | ItemType.Ring)), 100);

            MajorMagicType.AddEntry(MajorRodTable, 45);
                MajorRodTable.AddEntry(new Item("Rod 1", type: (ItemType.Magic | ItemType.Rod)), 25);
                MajorRodTable.AddEntry(new Item("Rod 2", type: (ItemType.Magic | ItemType.Rod)), 65);
                MajorRodTable.AddEntry(new Item("Rod 3", type: (ItemType.Magic | ItemType.Rod)), 100);

            MajorMagicType.AddEntry(MajorScrollTable, 55);
                MajorScrollTable.AddEntry(new Item("Scroll 1", type: (ItemType.Magic | ItemType.Scroll)), 25);
                MajorScrollTable.AddEntry(new Item("Scroll 2", type: (ItemType.Magic | ItemType.Scroll)), 65);
                MajorScrollTable.AddEntry(new Item("Scroll 3", type: (ItemType.Magic | ItemType.Scroll)), 100);

            MajorMagicType.AddEntry(MajorStaffTable, 75);
                MajorStaffTable.AddEntry(new Item("Staff 1", type: (ItemType.Magic | ItemType.Staff)), 25);
                MajorStaffTable.AddEntry(new Item("Staff 2", type: (ItemType.Magic | ItemType.Staff)), 65);
                MajorStaffTable.AddEntry(new Item("Staff 3", type: (ItemType.Magic | ItemType.Staff)), 100);

            MajorMagicType.AddEntry(MajorWandTable, 80);
                MajorWandTable.AddEntry(new Item("Wand 1", type: (ItemType.Magic | ItemType.Wand)), 25);
                MajorWandTable.AddEntry(new Item("Wand 2", type: (ItemType.Magic | ItemType.Wand)), 65);
                MajorWandTable.AddEntry(new Item("Wand 3", type: (ItemType.Magic | ItemType.Wand)), 100);

            MajorMagicType.AddEntry(MajorWondrousItemTable, 100);
                MajorWondrousItemTable.AddEntry(new Item("Wondrous Item 1", type: (ItemType.Magic | ItemType.Wondrous)), 25);
                MajorWondrousItemTable.AddEntry(new Item("Wondrous Item 2", type: (ItemType.Magic | ItemType.Wondrous)), 65);
                MajorWondrousItemTable.AddEntry(new Item("Wondrous Item 3", type: (ItemType.Magic | ItemType.Wondrous)), 100);
            #endregion

            #endregion

            #region Goods Table


            //GemTable.AddEntry(LowestGemTable, 25);
            //GemTable.AddEntry(LowerGemTable, 50);
            //GemTable.AddEntry(LowGemTable, 70);
            //GemTable.AddEntry(HighGemTable, 90);
            //GemTable.AddEntry(HigherGemTable, 99);
            //GemTable.AddEntry(HighestGemTable, 100);

            //LowestGemTable.LoadFromFile("LowestValueGems.Lewt", "Lowest Value Gem", 2, "");
            //LowerGemTable.LoadFromFile("LowerValueGems.Lewt", "Lower Value Gem", 2, "");
            //LowGemTable.LoadFromFile("LowValueGems.Lewt", "Low Value Gem", 2, "");
            //HighGemTable.LoadFromFile("HighValueGems.Lewt", "High Value Gem", 2, "");
            //HigherGemTable.LoadFromFile("HigherValueGems.Lewt", "Higher Value Gem", 2, "");
            //HighestGemTable.LoadFromFile("HighestValueGems.Lewt", "Highest Value Gem", 2, "");
            #endregion
        }
    }
}