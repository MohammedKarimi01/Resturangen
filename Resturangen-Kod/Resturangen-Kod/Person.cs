using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Resturangen_Kod
{
    internal class Person
    {
        public string Name { get; set; }
        public Person (string name)
        {
            Name = name;
        }
        public static string[] GetNames()
        {
            string[] NameList = {"Andersson", "Johansson", "Karlssson","Nillsson", "Eriksson"
            ,"Larsson","Olsson","Persson","Svensson","Gustavsson","Petterson","Johnsson","Jansson","Hansson","Bengtsson","Jönsson","Lindberg","Jakobsson","Magnusson","Lindström"
            ,"Olofsson","Lindkvist","Lindgren","Berg","Axelsson","Bergström","Lundberg","Lind","Lundgren","Lundqvist","Mattsson","Berglund","Fredriksson","Samberg","Henriksson"
            ,"Ali","Forsberg","Sjöberg","Walin","Engström","Eklund","Danielsson","Lundin","Håkansson","Björk","Bergman","Gunnarsson","Wikström","Holm","Samuelsson","Isaksson"
            ,"Fransson","Bergkvist","Nyström","Holmberg","Arvidsson","Lövgren","Söderberg","Nyberg","Ahmed","Blomqvist","Classon","Nordström","Hassan","Mårtensson","Lundström"
            ,"Viklund","Björklund","Eliasson","Berggren","Pålsson","Sandström","Nordin","Lund","Falk","Ström","Åberg","Ekström","Hermansson"};

            return NameList;
        }

        public  static List<Person> CreatingGuests(string[] NameList)
        {
            List<Person> Guests = new List<Person>();
            
            int balance = 0;
            Random rnd = new Random();
            
            foreach (string name in NameList)
            {
                balance = rnd.Next(50, 350);
                Guests.Add(new Person(name + " " + balance)); 
            }
            return Guests;
        }
    }
    
        
    internal class Chefs : Person
    {
        // Kockens kompetens är en rating från 1-10
        public int Competence { get; set; }
        public Chefs(string name, int competence) : base(name)
        {
            Competence = competence;
        }
        public static void CreatingChefs()
        {
            List<Person> Chefs = new List<Person>();
            string[] ChefNames = { "Mohammed", "Thom", "Bilal", "Daniel", "Erik", };
            Random rnd = new Random();

            foreach (string name in ChefNames)
            {
                int _Competence = 1;
                for (int i = 0; i < 1; i++)
                {
                    _Competence = rnd.Next(5, 11);
                }
                Chefs.Add(new Person(name));
            }
        }
    }
    internal class Waiter : Person
    {
        public Waiter(string name, int servicelevel) : base(name)
        {
            ServiceLevel = servicelevel;
        }
        public static List<Person> CreatingWaiter()
        {
            List<Person> Waiters = new List<Person>();
            string[] WaiterNames = { "Elias", "Emma", "Kenneth", };
            Random rnd = new Random();
            foreach (string name in WaiterNames)
            {
                int _ServiceLvL = 1;
                for (int i = 0; i < 1; i++)
                {
                    _ServiceLvL = rnd.Next(5,11);
                }
                Waiters.Add(new Person(name + " " + _ServiceLvL));
            }
            return Waiters;
        }
        // Servitörens Service level är en rating från 1-10
        public int ServiceLevel { get; set; }

    }
    internal class Guests : Person
    {

        public Guests(string name, int balance, bool satisfaction) : base(name)
        {
            Name = name;
            Balance = balance;
            Satisfaction = satisfaction;

        }
        //public static int GetMoney()
        //{
        //    Random rnd = new Random();
        //    int amountofmoney = 0;
        //    amountofmoney = rnd.Next(100,1000);
        //    return amountofmoney;
        //}
      

        public int GroupSize { get; set; }
        public int Balance { get; set; }
        public bool Satisfaction { get; set; }

        //Ändrar på propen senare.
        //public bool Allergies { get; set; }
    }
}
