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
    public partial class LollipopForm : Form
    {
        Model m_model;
        public LollipopForm(string name, string candy, Model modelObj)
        {
            
            //open and set up form
            InitializeComponent();

            //set m_model to passed in Model
            m_model = modelObj;
            Console.WriteLine(" m_model : " + m_model.ToString());

            //get customer name to pass to form 1
            string str = name + " selected : ";
            nameLable.Text = str;


            Console.WriteLine(name + "(passed to form) selected : " + candy);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            //Console.WriteLine("flavor selected : " + comboBoxLollipopSelection.SelectedItem.ToString());
            //adding new lollipop to list;
            decimal quantity = numericUpDown1.Value = 1;
            string lollipopFlavor = comboBoxLollipopSelection.SelectedItem.ToString();
            string cherry = "Cherry";
            string lime = "Lime";
            if (lollipopFlavor.Contains(cherry))
            {
                Lollipop newLollipop = new Lollipop(lollipopFlavor, 5.30, quantity);
                m_model.AddLollipopInList(newLollipop);

                this.Hide();
                MainNavigation aMainNavigation = new MainNavigation(m_model);
                aMainNavigation.Closed += (s, args) => this.Close();
                aMainNavigation.Show();
            }
            else if (lollipopFlavor.Contains(lime))
            {
                Lollipop newLollipop = new Lollipop(lollipopFlavor, 4.00, quantity);
                m_model.AddLollipopInList(newLollipop);

                this.Hide();
                MainNavigation aMainNavigation = new MainNavigation(m_model);
                aMainNavigation.Closed += (s, args) => this.Close();
                aMainNavigation.Show();
            }
            else
            {
                Lollipop newLollipop = new Lollipop(lollipopFlavor, 3.89, quantity);
                m_model.AddLollipopInList(newLollipop);

                this.Hide();
                MainNavigation aMainNavigation = new MainNavigation(m_model);
                aMainNavigation.Closed += (s, args) => this.Close();
                aMainNavigation.Show();
            }


        }
        private void LollipopForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxLollipopSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lollipopFlavor = comboBoxLollipopSelection.SelectedItem.ToString();
            string cherry = "Cherry";
            string lime = "Lime";

            if (lollipopFlavor.Contains(cherry))
            {
                string str = lollipopFlavor + " Price $5.30";
                flavorSelectionL.Text = str;
            }
            else if (lollipopFlavor.Contains(lime))
            {
                string str = lollipopFlavor + " Price $4.00";
                flavorSelectionL.Text = str;
            }
            else
            {
                string str = lollipopFlavor + " Price $3.89";
                flavorSelectionL.Text = str;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
