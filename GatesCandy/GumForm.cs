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
    public partial class GumForm : Form
    {
        Model m_model;
        public GumForm(string name, string candy, Model modelObj)
        {
            InitializeComponent();

            m_model = modelObj;
            
            string str = name + " selected : ";
            nameLable.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal quantity = numericUpDown1.Value;
            string gumFlavor = comboBoxGumSelection.SelectedItem.ToString();
            string bubble = "Bubble Gum";
            string mint = "Mint";
            if (gumFlavor.Contains(bubble))
            {
                Gum newGum = new Gum(gumFlavor, 3.25, quantity);
                m_model.AddGumInList(newGum);

                this.Hide();
                MainNavigation aMainNavigation = new MainNavigation(m_model);
                aMainNavigation.Closed += (s, args) => this.Close();
                aMainNavigation.Show();
            }
            else if (gumFlavor.Contains(mint))
            {
                Gum newGum = new Gum(gumFlavor, 2.20, quantity);
                m_model.AddGumInList(newGum);

                this.Hide();
                MainNavigation aMainNavigation = new MainNavigation(m_model);
                aMainNavigation.Closed += (s, args) => this.Close();
                aMainNavigation.Show();
            }
            else
            {
                Gum newGum = new Gum(gumFlavor, 2.75, quantity);
                m_model.AddGumInList(newGum);

                this.Hide();
                MainNavigation aMainNavigation = new MainNavigation(m_model);
                aMainNavigation.Closed += (s, args) => this.Close();
                aMainNavigation.Show();
            }


        }

        private void GumForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxGumSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string gumFlavor = comboBoxGumSelection.SelectedItem.ToString();
            string bubble = "Bubble Gum";
            string mint = "Mint";
            
            if (gumFlavor.Contains(bubble))
            {
                string str = gumFlavor + " Price $3.25";
                label3Gum.Text = str;
                Console.WriteLine(" str  " + str);
            }
            else if (gumFlavor.Contains(mint))
            {
                string str = gumFlavor + " Price $2.20";
                label3Gum.Text = str;
            }
            else
            {
                string str = gumFlavor + " Price $2.75";
                label3Gum.Text = str;
            }
        }
    }
}
