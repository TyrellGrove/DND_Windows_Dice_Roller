namespace WindowsFormsApp1
{
    partial class Dice_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dice_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypecomboBox1 = new System.Windows.Forms.ComboBox();
            this.DicecomboBox2 = new System.Windows.Forms.ComboBox();
            this.BonuscomboBox3 = new System.Windows.Forms.ComboBox();
            this.ResultTextBoxLabel = new System.Windows.Forms.Label();
            this.ValueLable = new System.Windows.Forms.Label();
            this.RollButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dice Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "# of Dice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bonuses";
            // 
            // TypecomboBox1
            // 
            this.TypecomboBox1.FormattingEnabled = true;
            this.TypecomboBox1.Items.AddRange(new object[] {
            "D20",
            "D12",
            "D10",
            "D8",
            "D6",
            "D4",
            "D3",
            "Coin Toss",
            "D100"});
            this.TypecomboBox1.Location = new System.Drawing.Point(75, 10);
            this.TypecomboBox1.Name = "TypecomboBox1";
            this.TypecomboBox1.Size = new System.Drawing.Size(121, 21);
            this.TypecomboBox1.TabIndex = 3;
            this.TypecomboBox1.SelectedIndexChanged += new System.EventHandler(this.TypecomboBox1_SelectedIndexChanged);
            // 
            // DicecomboBox2
            // 
            this.DicecomboBox2.FormattingEnabled = true;
            this.DicecomboBox2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.DicecomboBox2.Location = new System.Drawing.Point(75, 40);
            this.DicecomboBox2.Name = "DicecomboBox2";
            this.DicecomboBox2.Size = new System.Drawing.Size(41, 21);
            this.DicecomboBox2.TabIndex = 4;
            this.DicecomboBox2.SelectedIndexChanged += new System.EventHandler(this.DicecomboBox2_SelectedIndexChanged);
            // 
            // BonuscomboBox3
            // 
            this.BonuscomboBox3.FormattingEnabled = true;
            this.BonuscomboBox3.Items.AddRange(new object[] {
            "0",
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
            this.BonuscomboBox3.Location = new System.Drawing.Point(75, 67);
            this.BonuscomboBox3.Name = "BonuscomboBox3";
            this.BonuscomboBox3.Size = new System.Drawing.Size(41, 21);
            this.BonuscomboBox3.TabIndex = 5;
            this.BonuscomboBox3.SelectedIndexChanged += new System.EventHandler(this.BonuscomboBox3_SelectedIndexChanged);
            // 
            // ResultTextBoxLabel
            // 
            this.ResultTextBoxLabel.AutoSize = true;
            this.ResultTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBoxLabel.Location = new System.Drawing.Point(257, 9);
            this.ResultTextBoxLabel.Name = "ResultTextBoxLabel";
            this.ResultTextBoxLabel.Size = new System.Drawing.Size(60, 16);
            this.ResultTextBoxLabel.TabIndex = 6;
            this.ResultTextBoxLabel.Text = "Results";
            this.ResultTextBoxLabel.Visible = false;
            // 
            // ValueLable
            // 
            this.ValueLable.AutoSize = true;
            this.ValueLable.Location = new System.Drawing.Point(257, 37);
            this.ValueLable.Name = "ValueLable";
            this.ValueLable.Size = new System.Drawing.Size(34, 13);
            this.ValueLable.TabIndex = 7;
            this.ValueLable.Text = "Value";
            this.ValueLable.Visible = false;
            // 
            // RollButton
            // 
            this.RollButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RollButton.Image = ((System.Drawing.Image)(resources.GetObject("RollButton.Image")));
            this.RollButton.Location = new System.Drawing.Point(142, 37);
            this.RollButton.Name = "RollButton";
            this.RollButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RollButton.Size = new System.Drawing.Size(54, 51);
            this.RollButton.TabIndex = 8;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // Dice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 108);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.ValueLable);
            this.Controls.Add(this.ResultTextBoxLabel);
            this.Controls.Add(this.BonuscomboBox3);
            this.Controls.Add(this.DicecomboBox2);
            this.Controls.Add(this.TypecomboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dice_Form";
            this.Text = "Dice Roller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypecomboBox1;
        private System.Windows.Forms.ComboBox DicecomboBox2;
        private System.Windows.Forms.ComboBox BonuscomboBox3;
        private System.Windows.Forms.Label ResultTextBoxLabel;
        private System.Windows.Forms.Label ValueLable;
        private System.Windows.Forms.Button RollButton;
    }
}

