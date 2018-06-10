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
    public partial class MainNavigation : Form
    {
       // create object from model class it to m_modelObj
        private Model m_modelObj;
       //program starts here, pass in model class
        public MainNavigation(Model modelObj)
        {
            //set up component 
            InitializeComponent();

            //model class object
            m_modelObj = modelObj;
            Console.WriteLine(" m_model : " + modelObj.ToString());

            //subscribing an even of Model class, 
            //this will handle your logic what you want to perform on adding new Chocolate
            List<Chocolate> chocolateList = m_modelObj.ChocolateList;
            if (chocolateList != null)
            {
                //turn list into string 
                StringBuilder builder = new StringBuilder();
                foreach (var item in chocolateList)
                {
                    Console.WriteLine("list item " + item.flavor + "price $" + item.cost);
                    builder.Append(item.quantity + " " + item.flavor + " price $" + item.cost).Append("\n"); ;
                    
                }
                string result = builder.ToString(); // Get string from StringBuilder
                label1.Text = result;
                Console.WriteLine(result);
            }

            List<Lollipop> lollipopList = m_modelObj.LollipopList;
            if (lollipopList != null)
            {
                StringBuilder builder = new StringBuilder();
                foreach (var item in lollipopList)
                {
                    Console.WriteLine("list item " + item.flavor + "price $" + item.cost);
                    builder.Append(item.quantity + " " + item.flavor + " price $" + item.cost).Append("\n"); ;

                }
                string result = builder.ToString(); // Get string from StringBuilder
                label7.Text = result;
                Console.WriteLine(result);
            }

            List<Gum> gumList = m_modelObj.GumList;
            if (gumList != null)
            {
                StringBuilder builder = new StringBuilder();
                foreach (var item in gumList)
                {
                    Console.WriteLine("list item " + item.flavor + "price $" + item.cost);
                    builder.Append(item.quantity + " " + item.flavor + " price $" + item.cost).Append("\n"); ;

                }
                string result = builder.ToString(); // Get string from StringBuilder
                label9.Text = result;
                Console.WriteLine(result);
            }
        }

       /* public void m_modelObj_ChocolateAdded(Chocolate newChocolate)
        {
            //perform your task what you want to do with newly added chocolate


            //if you want whole list of chocolates
            List<Chocolate> chocolateList = m_modelObj.ChocolateList;
            foreach (var item in chocolateList)
            {
                Console.WriteLine(item);
                
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            //candy selection
            string candy = comboBox1.SelectedItem.ToString();
            string chocolate = "Chocolate";
            string lollipops = "Lollipops";

            if (candy.Contains(chocolate))
            {   //hide main form
                this.Hide();
                //pass name in textBox.text, candy from dropdown and model class
                ChocolateForm aForm1 = new ChocolateForm(textBox1.Text, candy, m_modelObj);
                //close main form
                aForm1.Closed += (s, args) => this.Close();
                //show choclate form
                aForm1.Show();
            }
            else if (candy.Contains(lollipops))
            {
                this.Hide();
                LollipopForm aLollipopForm = new LollipopForm(textBox1.Text, candy, m_modelObj);
                aLollipopForm.Closed += (s, args) => this.Close();
                aLollipopForm.Show();
            }
            else
            {
                this.Hide();
                GumForm aGumForm = new GumForm(textBox1.Text, candy, m_modelObj);
                aGumForm.Closed += (s, args) => this.Close();
                aGumForm.Show();
            }
           

           



        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainNavigation_Load(object sender, EventArgs e)
        {

        }

        
    }
}
