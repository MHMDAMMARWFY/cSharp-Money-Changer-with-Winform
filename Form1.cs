using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MONEYCHANGER_RM_testExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void buttonDenominate_Click(object sender, EventArgs e)
        {
            int totalAmount = int.Parse(textBoxTotalRM.Text);
            int rm50Count = totalAmount / 50;
            int rm20Count = (totalAmount % 50) / 20;
            int rm10Count = ((totalAmount % 50) % 20) / 10;
            int rm5Count = (((totalAmount % 50) % 20) % 10) / 5;
            int rm1Count = (((totalAmount % 50) % 20) % 10) % 5;

            label10.Text = rm50Count.ToString();
            label9.Text = rm20Count.ToString();
            label8.Text = rm10Count.ToString();
            label7.Text = rm5Count.ToString();
            label6.Text = rm1Count.ToString();


            /*int[] denominations = { 50, 20, 10, 5, 1 };
            int numDenominations = 5;

            //int rm50, rm20, rm10, rm5, rm1;

            int[]count = new int[5];

            for (int i = 0; i < numDenominations; i++)
            {
                count[i] = amount / denominations[i];
                amount %= denominations[i];
                listBoxSeperateAmount.Items.Add($"RM{denominations[i]} x {count[i]}\n");
     
    

            }*/
            listBoxSeperateAmount.Items.Add("\n");
        }

        private void listBoxSeperateAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            label9.Text = "";
            label8.Text = "";
            label7.Text = "";
            label6.Text = "";


            /*foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear(); // Clear all text boxes
                }
                else if (control is ListBox listBox)
                {
                    listBox.Items.Clear(); // Clear all list boxes
                }
            }*/
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
