using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLewtz
{
    public class Item : IObject
    {
        private int mBonus = 0;
        public ItemType Type;

        private List<Item> mAbilties = new List<Item>();

        public Item(string name = "Base Item", int cost = 0, int probability = 0, bool enabled = true, bool always = false, ItemType type = ItemType.None)
        {
            Name = name;
            Cost = cost;
            Probability = probability;
            isEnabled = enabled;
            Always = always;
            isEnabled = true;
            parentTable = null;

            Type = type;
        }

        public void AddAbility(Item ability)
        {
            mAbilties.Add(ability);
        }

        public void SetAbilities(List<Item> abilities)
        {
            mAbilties = abilities;
        }

        public override string ToString()
        {
            string abilityBuffer = "";
            if (mAbilties != null)
            {
                foreach (Item ability in mAbilties)
                {
                    abilityBuffer += ability.Name + "\r\n";
                }
            }
            return Name + " cost: " + Cost / 100 + " GP. Types: " + Type.ToString() + ((abilityBuffer == "") ? "" : "\r\n Abilities -> \r\n" + abilityBuffer);
        }

        public int Cost { get; set; }

        #region Interface Implementation
        public int rollCount { get; set; }

        public string Name { get; set; } //"Weapon Table" or "Dagger"
        public bool isEnabled { get; set; } //is this able to be rolled?
        public int Probability { get; set; }
        public bool Always { get; set; } //is this always included?

        public LootTable parentTable { get; set; } //the table this table belongs to

        #endregion

        #region EVENTS
        public event EventHandler hit;

        public virtual void OnHit(EventArgs e)
        {
            if (hit != null)
                hit(this, e);
        }
        #endregion
    }
}
