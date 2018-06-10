using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatesCandy
{
    public delegate void ChocolateAddedEventHander(Chocolate newChocolate);
    
    public delegate void LollipopAddedEventHander(Lollipop newLollipop);

    public delegate void GumAddedEventHander(Gum newGum);

    public class Model
    {
        //An Event which will be raised when you add new chocolate
        public event ChocolateAddedEventHander ChocolateAdded;
                
        public List<Chocolate> ChocolateList = new List<Chocolate>();
        public void AddChocolateInList(Chocolate chocolate)
        {
            ChocolateList.Add(chocolate);

            if (ChocolateAdded != null)
                ChocolateAdded(chocolate);
                Console.WriteLine("chocolate added!");
        }

        //Lollipop list
        
        public event LollipopAddedEventHander LollipopAdded;

        public List<Lollipop> LollipopList = new List<Lollipop>();
        public void AddLollipopInList(Lollipop lollipop)
        {
            LollipopList.Add(lollipop);

            if (LollipopAdded != null)
                LollipopAdded(lollipop);
                Console.WriteLine("lollipop added!");
        }

        //Gum list

        public event GumAddedEventHander GumAdded;

        public List<Gum> GumList = new List<Gum>();
        public void AddGumInList(Gum gum)
        {
            GumList.Add(gum);

            if (GumAdded != null)
                GumAdded(gum);
                Console.WriteLine("Gum added!");
        }
    }
    
}
