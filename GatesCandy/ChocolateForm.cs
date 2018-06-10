using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatesCandy
{
    
    public partial class ChocolateForm : Form
    {
        Model m_model;
        
        public ChocolateForm(string name, string candy, Model modelObj)
        {
            //open and set up form
            InitializeComponent();

            //set m_model to passed in Model
            m_model = modelObj;
            Console.WriteLine(" m_model : " + m_model.ToString());

            //get customer name to pass to form 1
            string str = name + " selected : ";
            label1.Text = str;

            
            Console.WriteLine(name + "(passed to form) selected : " + candy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //set variables to create new object in Chocolate class
            Console.WriteLine("flavor selected : " + comboBoxChocolateSelection.SelectedItem.ToString());
            //adding new chocolate to list;
            decimal quantity = numericUpDown1.Value;
            string chocolateFlavor = comboBoxChocolateSelection.SelectedItem.ToString();
            string darkChocolate = "Dark Chocolate";
            string whiteChocolate = "White Chocolate";
            //conditional to based on which selection from the flavor drop down
            if (chocolateFlavor.Contains(darkChocolate))
            {
                //choloate object created
                Chocolate newChocolate = new Chocolate(chocolateFlavor, 9.50, quantity);
                //add object to list in the model class
                m_model.AddChocolateInList(newChocolate);
                //hide current form
                this.Hide();
                //pass model information to new main screen... midel info will be reset if we reutrn back to the origional model
                MainNavigation aMainNavigation = new MainNavigation(m_model);
                aMainNavigation.Closed += (s, args) => this.Close();
                aMainNavigation.Show();
            }
            else if (chocolateFlavor.Contains(whiteChocolate))
            {
                Chocolate newChocolate = new Chocolate(chocolateFlavor, 5.00, quantity);
                m_model.AddChocolateInList(newChocolate);

                this.Hide();
                MainNavigation aMainNavigation = new MainNavigation(m_model);
                aMainNavigation.Closed += (s, args) => this.Close();
                aMainNavigation.Show();
            }
            else
            {
                Chocolate newChocolate = new Chocolate(chocolateFlavor, 7.60, quantity);
                m_model.AddChocolateInList(newChocolate);

                this.Hide();
                MainNavigation aMainNavigation = new MainNavigation(m_model);
                aMainNavigation.Closed += (s, args) => this.Close();
                aMainNavigation.Show();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxChocolateSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chocolateFlavor = comboBoxChocolateSelection.SelectedItem.ToString();
            string darkChocolate = "Dark Chocolate";
            string whiteChocolate = "White Chocolate";

            if (chocolateFlavor.Contains(darkChocolate))
            {
                string str = chocolateFlavor + " Price $9.50";
                label3.Text = str;
            }
            else if(chocolateFlavor.Contains(whiteChocolate))
            {
                string str = chocolateFlavor + " Price $5.00";
                label3.Text = str;
            }
            else
            {
                string str = chocolateFlavor + " Price $7.60";
                label3.Text = str;
            }
        }

       
    }
}
