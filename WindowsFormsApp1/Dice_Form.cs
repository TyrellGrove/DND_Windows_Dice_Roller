using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dice_Form : Form
    {
        public int min = 1;
        public int max = 1;
        public int rolls = 1;
        public int Bonusses = 0;

        public Dice_Form()
        {
            InitializeComponent();
            TypecomboBox1.SelectedItem = "D20";
            DicecomboBox2.SelectedItem = "1";
            BonuscomboBox3.SelectedItem = "0";
        }

        private void TypecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultTextBoxLabel.Visible = false;
            ValueLable.Visible = false;
            ValueLable.Text = string.Empty;
        }

        private void DicecomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultTextBoxLabel.Visible = false;
            ValueLable.Visible = false;
            ValueLable.Text = string.Empty;
        }

        private void BonuscomboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResultTextBoxLabel.Visible = false;
            ValueLable.Visible = false;
            ValueLable.Text = string.Empty;
        }

        private int? TypecomboBox1_CurrentValue(string s)
        {
            int? Value = null;

            if (s == "D20") Value = 21;
            if (s == "D12") Value = 12;
            if (s == "D10") Value = 11;
            if (s == "D8") Value = 9;
            if (s == "D6") Value = 7;
            if (s == "D4") Value = 5;
            if (s == "D3") Value = 4;
            if (s == "Coin Toss") Value = 3;
            if (s == "D100") Value = 100;

            return Value;
        }

        private Boolean DoWork()
        {
            int min = 1;
            int Total = 0;
            try { max = Convert.ToInt32(TypecomboBox1_CurrentValue(TypecomboBox1.Text)); } catch { MessageBox.Show("You must select a Type of Dice."); return false; }
            try { rolls = Convert.ToInt32(DicecomboBox2.Text); } catch { MessageBox.Show("You must select the # of Dice we are rolling."); return false; }
            try { Bonusses = Convert.ToInt32(BonuscomboBox3.Text); } catch { MessageBox.Show("You must input your bonuses."); return false; }

            for (int i = 0; i < rolls; i++)
            {
                System.Threading.Thread.Sleep(111);
                int myRandom = new Random().Next(min, max);
                Total += myRandom;
                ValueLable.Text += myRandom.ToString() + " ";
            }

            if (Bonusses > 0)
            {
                Total += Bonusses;
                ValueLable.Text += "+ " + Bonusses.ToString() + "\r\nTotal = " + Total.ToString();
            }
            else ValueLable.Text += "\r\nTotal = " + Total.ToString();
            ResultTextBoxLabel.Visible = true;
            ValueLable.Visible = true;
            return true;
        } 

        private void RollButton_Click(object sender, EventArgs e)
        {
            ValueLable.Text = string.Empty;
            Boolean b = DoWork();
        }
    }
}
