using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpLewtz
{
    public partial class InputControl : UserControl
    {
        public bool    isChecked;
        public int     count;
        public int     level = 1;
        public string  coins;
        public string  goods;
        public string  items;



        public void UpdateFields()
        {
            CheckBox1.Checked = isChecked;
            NumberToRollBox1.Text = count.ToString();
            CoinsBox1.Text = coins;
            GoodsBox1.Text = goods;
            ItemsBox1.Text = items;
        }

        public InputControl()
        {
            InitializeComponent();
        }


        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = CheckBox1.Checked;
        }

        private void LevelBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            level = Int32.Parse(LevelBox1.Text);
            if(level == 0)
            {
                level = 1;
            }
            switch (level)
            {
                case 1:
                    MessageBox.Show("1!");
                    break;
                case 2:
                    MessageBox.Show("2!");
                    break;
                default:
                    break;
            }
        }

        private void GoodsBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            goods = GoodsBox1.Text;
        }

        private void CoinsBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            coins = CoinsBox1.Text;
        }

        private void ItemsBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            items = ItemsBox1.Text;
        }

        private void NumberToRollBox1_TextChanged(object sender, EventArgs e)
        {
            if(!Int32.TryParse(NumberToRollBox1.Text, out count))
            {
                count = 0;
                //MessageBox.Show("Fucking shit! Use an integer bitchcakes");
            }
            NumberToRollBox1.Text = count.ToString();
        }

        
    }
}