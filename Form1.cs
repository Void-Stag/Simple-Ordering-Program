using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Items = new SortedDictionary<string, decimal>();//Creates a lookup table of two dataype values.
            //Coffee
            Items.Add("Filter £2.10", 2.10M);// Adds string and decimal value to lookup table.
            Items.Add("Espresso £2.25", 2.25M);
            Items.Add("Cappachino £2.70", 2.70M);
            Items.Add("Americano £2.35", 2.35M);
            Items.Add("Latte £2.80", 2.80M);
            Items.Add("Mocha £2.95", 2.95M);
            Items.Add("Hot Chocolate £2.95", 2.95M);
            Items.Add("Iced Coffee £2.95", 2.95M);
            Items.Add("Shot of Caramel £0.50", 0.50M);
            Items.Add("Shot of Hazelnut Syrup £0.50", 0.50M);
            Items.Add("Shot of Vanilla £0.50", 0.50M);

            //Tea
            Items.Add("English Breakfast Regular £2.65", 2.65M);
            Items.Add("English Breakfast Decaf £2.95", 2.95M);
            Items.Add("Earl Grey £2.65", 2.65M);
            Items.Add("Darjeeling £2.65", 2.65M);
            Items.Add("Peppermint £2.65", 2.65M);
            Items.Add("Chamomile £2.70", 2.70M);
            Items.Add("Jasmine Dragon Peal £2.95", 2.95M);
            Items.Add("Rooibos £2.95", 2.95M);
            Items.Add("Chai Tea £2.70", 2.70M);

            //Cake
            Items.Add("Organic Carrot Cake £2.28", 2.28M);
            Items.Add("Victoria Sponge £1.99", 1.99M);
            Items.Add("Sticky Apple Caramel £2.28", 2.28M);
            Items.Add("Dutch Chunky Apple Flan £2.18", 2.18M);
            Items.Add("Chocolate Fudge Cake £1.96", 1.96M);
            Items.Add("Chocolate & Coconut Sponge £0.82", 0.82M);

            //Total cost
            total_cost = 0.0M;
        }



        SortedDictionary<String,decimal> Items; //Defines lookup table. 
        decimal total_cost;

        private void cboTea_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOrderlist.Items.Add(cboTea.SelectedItem);//Adds selected item to the listbox.

            decimal cost = 0.0M;//defines datatype
            if (Items.TryGetValue(cboTea.SelectedItem.ToString(), out cost)) //Searches for selected item in the lookup table for the item and its cost.
            {
                total_cost += cost; //Adds cost of the selected item from the lookup table to total cost.
                lblCost.Text ="£"+ total_cost.ToString(); //Updates the total cost with updated values.
            }
        }

        private void cboCoffee_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOrderlist.Items.Add(cboCoffee.SelectedItem);

            decimal cost = 0.0M;
            if (Items.TryGetValue(cboCoffee.SelectedItem.ToString(),out cost))
            {
                total_cost += cost;
                lblCost.Text = "£" + total_cost.ToString();
            }

        }

        private void cboCake_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOrderlist.Items.Add(cboCake.SelectedItem);

            decimal cost = 0.0M;
            if (Items.TryGetValue(cboCake.SelectedItem.ToString(), out cost))
            {
                total_cost += cost;
                lblCost.Text = "£" + total_cost.ToString();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            cboTea.Text = String.Empty;//Empties combobox
            cboCoffee.Text = String.Empty;//Empties combobox
            cboCake.Text = String.Empty;//Empties combobox
            lstOrderlist.Items.Clear();//Clears Listbox
            total_cost = 0.0M; // Resets the total cost value to £0.0
            lblCost.Text = "£" + total_cost.ToString();//Resets label

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            decimal cost = 0.0M;
            if (Items.TryGetValue(lstOrderlist.SelectedItem.ToString(), out cost))
            {
                total_cost -= cost; //Removes cost of the selected item from total cost using lookup table.
                lblCost.Text = "£" + total_cost.ToString();// Updates the total cost with updated values.
            }

            lstOrderlist.Items.RemoveAt(lstOrderlist.SelectedIndex);//Removes selected Item.
        }
    }
}
