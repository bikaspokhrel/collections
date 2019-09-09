using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnlistFruit_Click(object sender, EventArgs e)
        {
            List<string> FruitList = new List<string>();
            FruitList.Add("orange"); FruitList.Add("apple"); FruitList.Add("banana");
            FruitList.Sort(); //sort Alphabetically 
            btnlistFruit.Text = Convert.ToString(FruitList.Count); 
                              //count how many fruit and show on the button 
                              //This loops through each of the fruit and shows them in the list. It is the most common way to iterate through a list. 
            foreach (string fruit in FruitList) // Loop through List with foreach
            {
                lbxFruitList.Items.Add("For each " + fruit);
            } //this also loops through each of the fruit by counting up the index of ech one. 
            for (int i = 0; i < FruitList.Count; i++) // Loop through List with for
                    {
                    lbxFruitList.Items.Add("For " + FruitList[i]);
                }
        }

        private void BtnaddFruit_Click(object sender, EventArgs e)
        {
            List<string> FruitList = new List<string>();
            string x = txtFruit.Text;
            FruitList.Add(x);
            FruitList.Sort();
            lbxFruitList.Items.Add(x);
        }
    }
}
