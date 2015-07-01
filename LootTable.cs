using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SharpLewtz
{
    //Each time another table is added, add 100 to every value in that table and add the entries to the end of the contents
    //of the current table(s)
    //then roll (table) * d100 (roll 0-100)


    public class LootTable : ITable
    {
        public ItemType Type = ItemType.None;
        private static Random diceRoll = new Random();

        public LootTable(IEnumerable<IObject> contents = null, int probability = 0, bool enabled = true, bool always = false, ItemType type = ItemType.None)
        {
            if (contents != null)
                mcontents = contents.ToList();
            else
                ClearContents(); //there are no contents, bitch

            Probability = probability;
            isEnabled = enabled;
            Always = always;
            isEnabled = enabled;
            parentTable = null;

            Type = type;
        }

        public LootTable(string path, int probability = 0, bool enabled = true, bool always = false, ItemType type = ItemType.None, int rank = 0)
        {
            Probability = probability;
            isEnabled = enabled;
            Always = always;
            isEnabled = enabled;
            parentTable = null;

            Type = type;

            LoadFromFile(path, type, rank);

        }

        public void ClearContents()
        {
            mcontents = new List<IObject>();
        }

        public virtual void LoadFromFile(string path, ItemType type = ItemType.None, int rank = 0)
        {
            
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string str;
                    string loadName = "SHIT BROKE SON";
                    int cost = 0;
                    int prob = 0;



                    while ((str = file.ReadLine()) != null)
                    {
                        string[] strArray;

                        strArray = str.Split(',');

                        loadName = strArray[0]; //objectType or "Name" of thingy ("Dagger")

                        if (!Int32.TryParse(strArray[1], out cost))
                        {
                            MessageBox.Show("SHIT BROKE strArray[1] :  \"" + strArray[1] + "\" is not an integer. FIX IT BITCH.");
                        }

                        int index = 2 + rank;

                        if(index >= strArray.Length)
                        {
                            index = strArray.Length;
                        }

                        if (!Int32.TryParse(strArray[index], out prob))
                        {
                            MessageBox.Show("SHIT BROKE: strArray[2] : \"" + strArray[2] + "\" is not an integer. FIX IT BITCH."); ;
                        }
                        
                        if (prob <= 0)
                        {
                            continue; //skip this entry
                        }
                        else
                        {
                            mcontents.Add(new Item(loadName, cost, prob, type : Type));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to load from file: " + path);
            }
        }

        public void ToListView(ListView lv)
        {
            foreach(Item item in mcontents)
            {
                ListViewItem lvItem = new ListViewItem();
                if(!lv.Items.Contains(lvItem))
                {
                    lvItem.Text = item.Name;
                    lvItem.SubItems.Add(item.Cost.ToString());
                    lvItem.SubItems.Add(item.Probability.ToString());
                }
                lv.Items.Add(lvItem);
            }
        }

        public void AddEntry(IObject entry, int prob = 0, bool enabled = true, bool always = false)
        {
            mcontents.Add(entry);

            entry.Probability = prob;
            entry.isEnabled = enabled;
            entry.Always = always;

            entry.parentTable = this;
        }


        #region INTERFACE IMPLEMENTATIONS
        private int _rollCount = 1;
        public int rollCount
        {
            get
            {
                return _rollCount;
            }
            set
            {
                _rollCount = value;
            }
        }

        #region RESULT CALCULATION

        private IEnumerable<IObject> AddToResultList(IObject o)
        {
            if (o is ITable)
            {
                foreach(var item in ((ITable)o).Results)
                {
                    yield return item;
                }
            }
            else
            {
                yield return o;
            }
        }


        public virtual IEnumerable<Item> Results
        {
            get
            {
                //List<IObject> resultList = new List<IObject>();
                foreach (IObject o in mcontents.Where(e => e.Always && e.isEnabled)) //gets everything that is ALWAYS and enabled
                {
                    foreach(var item in AddToResultList(o))
                    {
                        yield return (Item)item;
                    }
                }


                int alwaysCount = Contents.Count(e => e.Always && e.isEnabled);

                int finalRollCount = rollCount - alwaysCount;
                               

                int previousProb = 0;

                int i = finalRollCount;

                

                while (finalRollCount > 0)
                {

                    IEnumerable<IObject> dropList = mcontents.Where(e => !e.Always && e.isEnabled); //Now roll on every item that has not already been added and is enabled

                    int roll = diceRoll.Next(1, 100);

                    foreach (IObject o in dropList)
                    {
                        if (roll > previousProb && roll <= o.Probability)
                        {
                            //AddToResultList(resultList, o);
                           
                            o.OnHit(EventArgs.Empty);
                            foreach (var item in AddToResultList(o))
                            {
                                yield return (Item)item;
                            }
                            break;
                        }
                        previousProb = o.Probability;
                    }
                    --finalRollCount;
                }
            }
        }

        public virtual void OnHit(EventArgs e)
        {
            if (hit != null)
                hit(this, e);
        }

        #endregion

        public IEnumerable<IObject> Contents { get { return mcontents; } }
        protected List<IObject> mcontents = new List<IObject>();

        public string Name { get; set; } //"Weapon Table" or "Dagger"
        public int Probability { get; set; }
        public bool isEnabled { get; set; } //is this able to be rolled?

        public bool Always { get; set; } //is this always included?

        public LootTable parentTable { get; set; } //the table this table belongs to

        public event EventHandler hit;

        #endregion
    }
}