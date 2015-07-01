namespace SharpLewtz
{
    partial class InputControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlInput0 = new System.Windows.Forms.Panel();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberToRollBox1 = new System.Windows.Forms.TextBox();
            this.ItemsBox1 = new System.Windows.Forms.ComboBox();
            this.GoodsBox1 = new System.Windows.Forms.ComboBox();
            this.LevelBox1 = new System.Windows.Forms.ComboBox();
            this.CoinsBox1 = new System.Windows.Forms.ComboBox();
            this.pnlInput0.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput0
            // 
            this.pnlInput0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInput0.Controls.Add(this.CheckBox1);
            this.pnlInput0.Controls.Add(this.label1);
            this.pnlInput0.Controls.Add(this.NumberToRollBox1);
            this.pnlInput0.Controls.Add(this.ItemsBox1);
            this.pnlInput0.Controls.Add(this.GoodsBox1);
            this.pnlInput0.Controls.Add(this.LevelBox1);
            this.pnlInput0.Controls.Add(this.CoinsBox1);
            this.pnlInput0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInput0.Location = new System.Drawing.Point(0, 0);
            this.pnlInput0.Name = "pnlInput0";
            this.pnlInput0.Size = new System.Drawing.Size(568, 39);
            this.pnlInput0.TabIndex = 37;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(4, 13);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(18, 17);
            this.CheckBox1.TabIndex = 4;
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(89, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "x   Level";
            // 
            // NumberToRollBox1
            // 
            this.NumberToRollBox1.Location = new System.Drawing.Point(28, 9);
            this.NumberToRollBox1.Name = "NumberToRollBox1";
            this.NumberToRollBox1.Size = new System.Drawing.Size(55, 22);
            this.NumberToRollBox1.TabIndex = 18;
            this.NumberToRollBox1.TextChanged += new System.EventHandler(this.NumberToRollBox1_TextChanged);
            // 
            // ItemsBox1
            // 
            this.ItemsBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsBox1.FormattingEnabled = true;
            this.ItemsBox1.Items.AddRange(new object[] {
            "None",
            "Half",
            "Standard",
            "Double",
            "Triple"});
            this.ItemsBox1.Location = new System.Drawing.Point(447, 9);
            this.ItemsBox1.Name = "ItemsBox1";
            this.ItemsBox1.Size = new System.Drawing.Size(116, 24);
            this.ItemsBox1.TabIndex = 16;
            this.ItemsBox1.SelectedIndexChanged += new System.EventHandler(this.ItemsBox1_SelectedIndexChanged);
            // 
            // GoodsBox1
            // 
            this.GoodsBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GoodsBox1.FormattingEnabled = true;
            this.GoodsBox1.Items.AddRange(new object[] {
            "None",
            "Half",
            "Standard",
            "Double",
            "Triple"});
            this.GoodsBox1.Location = new System.Drawing.Point(325, 9);
            this.GoodsBox1.Name = "GoodsBox1";
            this.GoodsBox1.Size = new System.Drawing.Size(116, 24);
            this.GoodsBox1.TabIndex = 15;
            this.GoodsBox1.SelectedIndexChanged += new System.EventHandler(this.GoodsBox1_SelectedIndexChanged);
            // 
            // LevelBox1
            // 
            this.LevelBox1.FormattingEnabled = true;
            this.LevelBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.LevelBox1.Location = new System.Drawing.Point(155, 9);
            this.LevelBox1.Name = "LevelBox1";
            this.LevelBox1.Size = new System.Drawing.Size(42, 24);
            this.LevelBox1.TabIndex = 17;
            this.LevelBox1.Text = "1";
            this.LevelBox1.SelectedIndexChanged += new System.EventHandler(this.LevelBox1_SelectedIndexChanged);
            // 
            // CoinsBox1
            // 
            this.CoinsBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoinsBox1.FormattingEnabled = true;
            this.CoinsBox1.Items.AddRange(new object[] {
            "None",
            "1/10",
            "Half",
            "Standard",
            "Double",
            "Triple"});
            this.CoinsBox1.Location = new System.Drawing.Point(203, 9);
            this.CoinsBox1.Name = "CoinsBox1";
            this.CoinsBox1.Size = new System.Drawing.Size(116, 24);
            this.CoinsBox1.TabIndex = 14;
            this.CoinsBox1.SelectedIndexChanged += new System.EventHandler(this.CoinsBox1_SelectedIndexChanged);
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlInput0);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(568, 39);
            this.pnlInput0.ResumeLayout(false);
            this.pnlInput0.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput0;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberToRollBox1;
        private System.Windows.Forms.ComboBox ItemsBox1;
        private System.Windows.Forms.ComboBox GoodsBox1;
        private System.Windows.Forms.ComboBox LevelBox1;
        private System.Windows.Forms.ComboBox CoinsBox1;
    }
}
