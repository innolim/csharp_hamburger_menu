using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch4_hambugerOrderPad
{
    public partial class Form1 : Form
    {
        //named constants
        const decimal baseBurgerPrice = 4.99m;
        const decimal cheese = .99m;
        const decimal friedEgg = 1.99m;
        const decimal bacon = 1.99m;
        const decimal avocado = .99m;
        const decimal fries = 2.99m;

        //variable
        decimal totalPrice = baseBurgerPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                totalPrice = baseBurgerPrice;
                if (creditRadioButton.Checked || cashRadioButton.Checked)

                //calculate total price as menu is chosen
                if (cheeseCheckBox.Checked)
                        totalPrice += cheese;
                if (friedeggCheckBox.Checked)
                    totalPrice += friedEgg;
                if (baconCheckBox.Checked)
                    totalPrice += bacon;
                if (avocadoCheckBox.Checked)
                    totalPrice += avocado;
                if (yesRadioButton.Checked)
                    totalPrice += fries;

                //10% discount applied to total price
                if (cashRadioButton.Checked)
                    totalPrice = totalPrice - (totalPrice * (decimal)0.1);

                totalLabel.Text = totalPrice.ToString("c"); //show total price in blank label box
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
                //clear inputs
            cheeseCheckBox.Checked = false;
            friedeggCheckBox.Checked = false;
            baconCheckBox.Checked = false;
            avocadoCheckBox.Checked = false;
            yesRadioButton.Checked = true;
            noRadioButton.Checked = false;
            addLabel.Text = "";
            totalLabel.Text = "";
            cashRadioButton.Checked = true;
            creditRadioButton.Checked = false;
            rareRadioButton.Checked = false;
            mediumRadioButton.Checked = false;
            welldoneRadioButton.Checked = true;
            addLabel.Text = "";

            totalPrice = baseBurgerPrice; //reset total price when all  inputs are clear
            cheeseCheckBox.Focus();                  
        }
        
        private void cheeseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cheeseCheckBox.Checked)
            addLabel.Text = "Add " + cheese;
            //add the cheese price to the toal price           
        }
        
        private void friedeggCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (friedeggCheckBox.Checked)
            addLabel.Text = "Add " + friedEgg;
        }

        private void baconCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (baconCheckBox.Checked)
                addLabel.Text = "Add " + bacon;
        }

        private void avocadoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (avocadoCheckBox.Checked)
                addLabel.Text = "Add " + avocado;
        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yesRadioButton.Checked)
                addLabel.Text = "Add " + fries;
        }

        private void rareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rareRadioButton.Checked)
            {
                MessageBox.Show("You selected rare."); //show message box if rare was chosen
            }
        }

        private void mediumRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumRadioButton.Checked)
            {
                MessageBox.Show("You selected medium.");
            }
        }

        private void welldoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (welldoneRadioButton.Checked)
            {
                MessageBox.Show("You selected well done.");
            }
        }
    } 
}
