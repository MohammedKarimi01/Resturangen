using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    internal class Person
    {
        public string Names { get; set; }
        //public List<Group> Groups = new List<Group>();
        //List<String> NameList = new List<String>();
        public Person (string name)
        {
            Names = name;
        }
        public static void CreatingPersons()
        {
            List<Person> Guests = new List<Person>();
            string[] ArrayNameList = {"Andersson", "Johansson", "Karlssson","Nillsson", "Eriksson"
            ,"Larsson","Olsson","Persson","Svensson","Gustavsson","Petterson","Johnsson","Jansson","Hansson","Bengtsson","Jönsson","Lindberg","Jakobsson","Magnusson","Lindström"
            ,"Olofsson","Lindkvist","Lindgren","Berg","Axelsson","Bergström","Lundberg","Lind","Lundgren","Lundqvist","Mattsson","Berglund","Fredriksson","Samberg","Henriksson"
            ,"Ali","Forsberg","Sjöberg","Walin","Engström","Eklund","Danielsson","Lundin","Håkansson","Björk","Bergman","Gunnarsson","Wikström","Holm","Samuelsson","Isaksson"
            ,"Fransson","Bergkvist","Nyström","Holmberg","Arvidsson","Lövgren","Söderberg","Nyberg","Ahmed","Blomqvist","Classon","Nordström","Hassan","Mårtensson","Lundström"
            ,"Viklund","Björklund","Eliasson","Berggren","Pålsson","Sandström","Nordin","Lund","Falk","Ström","Åberg","Ekström","Hermansson"};
            int balance = 0;
            Random rnd = new Random();
            
            foreach (string name in ArrayNameList)
            {
                balance = rnd.Next(50, 350);
                Guests.Add(new Person(name));
                Console.WriteLine(name +" har "+ balance + "kr");
            }
            Random random = new Random();
            int groupsize = random.Next(1, 5);
            Group group = new Group();
            Groups.Add(group);
            foreach (Person p in Guests)
            {

                int counter = 0;
                
                






                while (counter < groupsize)
                {
                    for (int i = 0; i < groupsize; i++)
                    {
                        Groups.Add(new Guests);
                    }
                }
            }
         
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
    internal class Waiters : Person
    {
        public Waiters(string name, int servicelevel) : base(name)
        {
            ServiceLevel = servicelevel;
        }
        //public static int WaiterServiceLvL()
        //{

        //    return _ServiceLvL;
        //}
        public static void CreatingWaiter()
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
                Waiters.Add(new Person(name));
            }
        }

        // Servitörens Service level är en rating från 1-10
        public int ServiceLevel { get; set; }

    }
    internal class Guests : Person
    {

        public Guests(string name, int groupsize, int amountofmoney, bool satisfaction) : base(name)
        {
            Names = name;
            GroupSize = groupsize;
            AmoutOfMoney = amountofmoney;
            Satisfaction = satisfaction;

        }
        public static int GetMoney()
        {
            Random rnd = new Random();
            int amountofmoney = 0;
            amountofmoney = rnd.Next(100,1000);
            return amountofmoney;
        }
        public static int GetGroups(int groupsize, List<string> groups)
        {
            Random rnd = new Random();
            int _groupsize = 0;
            _groupsize = rnd.Next(1, 5);
            groups.Add();

            return _groupsize;
        }

        public int GroupSize { get; set; }
        public int AmoutOfMoney { get; set; }
        public bool Satisfaction { get; set; }

        //Ändrar på propen senare.
        //public bool Allergies { get; set; }
    }
}
