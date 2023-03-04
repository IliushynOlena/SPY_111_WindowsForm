using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_List
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>();
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
           
            orders.Add(new Order(random.Next(1000)));
            orders.Add(new Order(random.Next(1000)));
            orders.Add(new Order(random.Next(1000)));
            orders.Add(new Order(random.Next(1000)));
            //ordersComboBox.Items.AddRange(orders.ToArray());
            UpdateOrdersComboBox();
        }
        private void UpdateOrdersComboBox()
        {
            ordersComboBox.DataSource = null;
            ordersComboBox.DataSource = orders;
            ordersComboBox.SelectedItem = null;
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            if (ordersComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an order from list!");
                return;
            }

            Order selectOrder = ordersComboBox.SelectedItem as Order;
            MessageBox.Show(selectOrder.ToString(), "Order detail", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ordersComboBox.SelectedItem = null;
          
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (ordersComboBox.SelectedIndex == -1) return;

            orders.RemoveAt(ordersComboBox.SelectedIndex);
            UpdateOrdersComboBox();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            orders.Add(new Order(numericUpDown1.Value));
            UpdateOrdersComboBox();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
            }
         
            textBox1.Clear();
        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No selected Item");
                return;
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void showListInfoBtn_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string res = "-----------Selected Item ----------\n";
                foreach (var item in listBox1.SelectedItems)
                {
                    res += item.ToString() + Environment.NewLine;
                }
                MessageBox.Show(res);
            }
        }

        private void MoveRightBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
                checkedListBox1.Items.Add(item);
        }

        private void moveLeftBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
             
            }
        }

        private void delCheckedBtn_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count>0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
            }
        }
    }


}
