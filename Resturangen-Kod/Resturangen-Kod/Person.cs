using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Resturangen_Kod
{
    public class Person
    {
        public string Name { get; set; }
        public string Order { get; set; }
        public Person(string name)
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
    
        
    public class Chefs
    {
        // Kockens kompetens är en rating från 1-10
        public int Competence { get; set; }
        public Chefs(int competence)
        {
            Competence = competence;
        }
        public static List<Person> CreatingChefs()
        {
           
            List<Person> Chefs = new List<Person>();

            string[] ChefNames = {"Mohammed", "Thom", "Bilal", "Daniel", "Erik"};


            int _Competence = 1;
            Random rnd = new Random();

            foreach (string name in ChefNames)
            {
                _Competence = rnd.Next(5, 11);
                Chefs.Add(new Person(name + " " + _Competence));
                Console.WriteLine(name + " " + _Competence);
            }
            return Chefs;
        }
    }
    public class Waiter 
    {
        public Waiter(string name, int servicelevel, bool busy) 
        {
            Name = name;
            ServiceLevel = servicelevel;
            Busy = busy;
            
        }
        public static List<Waiter> CreatingWaiters()
        {
            List<Waiter> Waiters = new List<Waiter>();
            string[] WaiterNames = { "Elias", "Emma", "Kenneth", };
            Random rnd = new Random();
            foreach (string name in WaiterNames)
            {
                int _ServiceLvL = 1;
                for (int i = 0; i < 1; i++)
                {
                    _ServiceLvL = rnd.Next(5,11);
                }
                Waiters.Add(new Waiter(name, _ServiceLvL, false));
            }
            return Waiters;
        }
        // Servitörens Service level är en rating från 1-10
        public int ServiceLevel { get; set; }
        public bool Busy { get; set; }
        public string Name { get; set; }
    }

    public class Guests : Person
    {

        public Guests(string name, int balance, bool satisfaction) : base(name)
        {
            Name = name;
            Balance = balance;
            Satisfaction = satisfaction;

        }

        public int GroupSize { get; set; }
        public int Balance { get; set; }
        public bool Satisfaction { get; set; }

    }
}
