using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLewtz
{
    class Coin : Item
    {
        private Random rand = new Random();

        private int DiceCount = 0;
        private int DiceSides = 0;
        private int Multiplier = 0;

        public Coin(string name = "Coin", bool enabled = true, bool always = false, int diceCount = 0, int diceSides = 0, int mult = 0, int cost = 0)
        {
            Name = name;
            isEnabled = enabled;
            Always = always;
            isEnabled = true;
            DiceCount = diceCount;
            DiceSides = diceSides;
            Multiplier = mult;
            Cost = cost;

            parentTable = null;
        }

        public void RollCost()
        {
            try
            {
                int TotalCount = 0;
                for (int i = 0; i < DiceCount; i++)
                {
                    TotalCount += rand.Next(1, DiceSides + 1);
                }
                Cost = TotalCount * Multiplier;
            }
            catch (ArgumentOutOfRangeException e)
            {
                System.Windows.Forms.MessageBox.Show("Index out of range! : From 1 to (" + DiceSides.ToString() + ")");
            }
        }

        public override void OnHit(EventArgs e)
        {
            RollCost();
        }

        public override string ToString()
        {
            return Cost + " " + Name;
        }
    }
}
