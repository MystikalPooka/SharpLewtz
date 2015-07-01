using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpLewtz
{

    public partial class Form1 : Form
    {


        ItemDirector director = new ItemDirector();
        
        //ItemBuilder MediumBuilder = new MediumItemBuilder();
        //ItemBuilder MajorBuilder = new MajorItemBuilder();
        
        //director.BuildItem(MinorBuilder);
        //
        
        LootTable testTable = new LootTable();
        Coin copperPiece = new Coin("Copper Piece", diceCount: 2, diceSides: 8, mult: 100);
        Coin silverPiece = new Coin("Silver Piece", diceCount: 1, diceSides: 10, mult: 100);
        Coin goldPiece = new Coin("Gold Piece", diceCount: 1, diceSides: 8, mult: 10);
        Coin platinumPiece = new Coin("Platinum Piece", diceCount: 1, diceSides: 6, mult: 1);

        public Form1()
        {
            InitializeComponent();
            LoadTables();
            
        }

        private void btnAddTreasure_Click(object sender, EventArgs e)
        {
            InputControl input = new InputControl();
            flowLayoutPanel1.Controls.Add(input);
        }

        private void btnRemoveTreasure_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 2)
            {
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
            }
        }

        private void GenerateLootButton_Click(object sender, EventArgs e)
        {
            ItemBuilder minorTestBuilder = new ConcreteItemBuilder();

            director.Construct(minorTestBuilder, "minor");

            textBox2.Text = "";
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is InputControl) 
                {
                    InputControl ic = (InputControl)c;

                    if (ic.count > 0 && ic.isChecked)
                    {
                        for (int i = 0; i < ic.count; ++i)
                        {
                            if (!chkCombineHoards.Checked)
                            {
                                if (i > 0)
                                {
                                    textBox2.Text += "\r\n";
                                }

                                textBox2.Text += "==========>HOARD " + (i + 1).ToString() + "<==========\r\n";
                            }

                            var m = testTable.Results;
                            foreach (IObject o in m)
                            {
                                try
                                {
                                    textBox2.Text += o.ToString() + "\r\n";
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                            }
                            
                        }
                    }
                }
            }
        }
        //b.add
        ///---->#DICKBUG CODE<----
        //textBox1.Text += "\r\n MOO" + counter + "8=";
        //for (int i = 0; i < ic.count; ++i)
        //{
        //    textBox1.Text += "=";
        //}
        //textBox1.Text += "D";
        //DO SHEETS.
        //like the laundry.*/
        //public static void GenerateItem(Item obj)
        //{


        //}

        //public void RollCost()
        //{
        //    try
        //    {
        //        int TotalCount = 0;
        //        for (int i = 0; i < DiceCount; i++)
        //        {
        //            TotalCount += rand.Next(1, DiceSides + 1);
        //        }
        //        Cost = TotalCount * Multiplier;
        //    }
        //    catch (ArgumentOutOfRangeException e)
        //    {
        //        System.Windows.Forms.MessageBox.Show("Index out of range! : From 1 to (" + DiceSides.ToString() + ")");
        //    }
        //}
    }
}
