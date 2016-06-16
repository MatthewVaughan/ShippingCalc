using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Project 06
// Date: 03/04/2015 09:15:19 am
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Project06
{
    public partial class FrmMain : Form
    {
        public string express { get; private set; }

        //Class level reference to Sale Calculator
        private ShippingExpense se;

        public FrmMain()
        {
            InitializeComponent();
            //Create Shipping expense object
            se = new ShippingExpense();
        }

        /// <summary>
        /// About Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display a message box showing the programmers name and class
            MessageBox.Show("Matthew Vaughan\nCS 1400 Sec 003");
        }

        /// <summary>
        /// Exit Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }

        /// <summary>
        /// Calculator Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare some constants
            const double STANDARD_ITEMS = 3;
            const double STANDARD_POUNDS = 1.45;
            const double STANDARD_SURCHARGE = 2.5;
            const double EXPRESS_ITEMS = 4;
            const double EXPRESS_POUNDS = 2.5;
            const double EXPRESS_SURCHARGE = 5;
            const double SAME_DAY_ITEMS = 5.5;
            const double SAME_DAY_POUNDS = 3;
            const double SAME_DAY_SURCHARGE = 8;

            //Declare some strings
            string standard = "Standard";
            string express = "Express";
            string sameDay = "Same Day";
            string item = "Item";
            string pound = "Pound";

            //Store user input from text box and create variable to store answer int
            double itemsPounds = double.Parse(txtNumItems.Text);

            //if user chooses standard shipping
            if (comboShipMethod.Text == standard)
            {
                //If user chooses standard shipping items
                if (comboCategory.Text == item && radioBtnYes.Checked)
                {
                    //Itemized shipping with surcharge
                    itemsPounds = itemsPounds * STANDARD_ITEMS + STANDARD_SURCHARGE;
                    se.SetStandard(itemsPounds);

                    //Get and display Standard
                    double get = se.GetStandard();
                    txtTotalCost.Text = ($"{get:C2}");
                }

                //If user chooses standard shipping items
                else if (comboCategory.Text == item && radioBtnNo.Checked)
                {
                    //Itemized Shipping No Surcharge
                    itemsPounds = itemsPounds * STANDARD_ITEMS;
                    se.SetStandard(itemsPounds);

                    //Get and display Standard
                    double get = se.GetStandard();
                    txtTotalCost.Text = ($"{get:C2}");
                }

                //If user chooses standard shipping pounds
                if (comboCategory.Text == pound && radioBtnYes.Checked)
                {
                    //Itemized shipping with surcharge
                    itemsPounds = itemsPounds * STANDARD_POUNDS + STANDARD_SURCHARGE;
                    se.SetStandard(itemsPounds);

                    //Get and display Standard
                    double get = se.GetStandard();
                    txtTotalCost.Text = ($"{get:C2}");
                }

                //If user chooses standard shipping pounds
                else if (comboCategory.Text == pound && radioBtnNo.Checked)
                {
                    //Itemized Shipping No Surcharge
                    itemsPounds = itemsPounds * STANDARD_POUNDS;
                    se.SetStandard(itemsPounds);

                    //Get and display Standard
                    double get = se.GetStandard();
                    txtTotalCost.Text = ($"{get:C2}");
                }

            }

            //If user chooses Express shipping
            else if (comboShipMethod.Text == express)
            {
                //If user chooses express shipping items
                if (comboCategory.Text == item && radioBtnYes.Checked)
                {
                    //Itemized shipping with surcharge
                    itemsPounds = itemsPounds * EXPRESS_ITEMS + EXPRESS_SURCHARGE;
                    se.SetExpress(itemsPounds);

                    //Get and display Express
                    double get = se.GetExpress();
                    txtTotalCost.Text = ($"{get:C2}");
                }

                //If user chooses express shipping items
                else if (comboCategory.Text == item && radioBtnNo.Checked)
                {
                    //Itemized Shipping No Surcharge
                    itemsPounds = itemsPounds * EXPRESS_ITEMS;
                    se.SetExpress(itemsPounds);

                    //Get and display Express
                    double get = se.GetExpress();
                    txtTotalCost.Text = ($"{get:C2}");
                }

                //If user chooses express shipping pounds
                if (comboCategory.Text == pound && radioBtnYes.Checked)
                {
                    //Itemized shipping with surcharge
                    itemsPounds = itemsPounds * EXPRESS_POUNDS + EXPRESS_SURCHARGE;
                    se.SetExpress(itemsPounds);

                    //Get and display Express
                    double get = se.GetExpress();
                    txtTotalCost.Text = ($"{get:C2}");
                }

                //If user chooses express shipping pounds
                else if (comboCategory.Text == pound && radioBtnNo.Checked)
                {
                    //Itemized Shipping No Surcharge
                    itemsPounds = itemsPounds * EXPRESS_POUNDS;
                    se.SetExpress(itemsPounds);

                    //Get and display Express
                    double get = se.GetExpress();
                    txtTotalCost.Text = ($"{get:C2}");
                }

            }

            //If user selects same day shipping
            else if (comboShipMethod.Text == sameDay)
            {
                //If user chooses same day shipping items
                if (comboCategory.Text == item && radioBtnYes.Checked)
                {
                    //Itemized shipping with surcharge
                    itemsPounds = itemsPounds * SAME_DAY_ITEMS + SAME_DAY_SURCHARGE;
                    se.SetSameDay(itemsPounds);

                    //Get and display Standard
                    double get = se.GetSameDay();
                    txtTotalCost.Text = ($"{get:C2}");
                }

                //If user chooses same day shipping items
                else if (comboCategory.Text == item && radioBtnNo.Checked)
                {
                    //Itemized Shipping No Surcharge
                    itemsPounds = itemsPounds * SAME_DAY_ITEMS;
                    se.SetSameDay(itemsPounds);

                    //Get and display Same Day
                    double get = se.GetSameDay();
                    txtTotalCost.Text = ($"{get:C2}");
                }

                //If user chooses same day shipping pounds
                if (comboCategory.Text == pound && radioBtnYes.Checked)
                {
                    //Itemized shipping with surcharge
                    itemsPounds = itemsPounds * SAME_DAY_POUNDS + SAME_DAY_SURCHARGE;
                    se.SetSameDay(itemsPounds);

                    //Get and display Same Day
                    double get = se.GetSameDay();
                    txtTotalCost.Text = ($"{get:C2}");
                }

                //If user chooses same day shipping pounds
                else if (comboCategory.Text == pound && radioBtnNo.Checked)
                {
                    //Itemized Shipping No Surcharge
                    itemsPounds = itemsPounds * SAME_DAY_POUNDS;
                    se.SetStandard(itemsPounds);

                    //Get and display same day
                    double get = se.GetSameDay();
                    txtTotalCost.Text = ($"{get:C2}");
                }

            }

            //In case user inputs anything else
            else
            {
                //Display 0 dollars
                txtTotalCost.Text = ("$0.00");
            }

        }

        /// <summary>
        /// Shipping Category Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Declare string variables
            string item = "Item";
            string pound = "Pound";

            //if user chooses item switch the label
            if (comboCategory.Text == item)
            {
                //display correct question
                lblNumItems.Text = "How many items?";
            }
            //if user chooses pound switch label accordingly
            else if (comboCategory.Text == pound)
            {
                //display correct question
                lblNumItems.Text = "How many pounds?";
            }
            //if nothing is selected
            else
            {
                //ask user to choose shipping category
                lblNumItems.Text = "(Please choose shipping rate)";
            }
        }
    }
}
