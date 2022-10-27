using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    internal class Persons
    {
        public string Names { get; set; }
        //List<String> NameList = new List<String>();

       
        
        
        
        
        
        public Persons (string name)
        {
            Names = name;
        }
        public static void CreatingPersons()
        {
            List<Persons> Guests = new List<Persons>();
            string[] ArrayNameList = {"Andersson", "Johansson", "Karlssson","Nillsson", "Eriksson"
            , "Larsson","Olsson","Persson","Svensson","Gustavsson","Petterson","Johnsson","Jansson","Hansson","Bengtsson","Jönsson","Lindberg","Jakobsson","Magnusson","´Lindström"
            ,"Olofsson","Lindkvist","Lindgren","Berg","Axelsson","Bergström","Lundberg","Lind","Lundgren","Lundqvist","Mattsson","Berglund","Fredriksson","Samberg","Henriksson"
            ,"Ali","Forsberg","Sjöberg","Walin","Engström","Eklund","Danielsson","Lundin","Håkansson","Björk","Bergman","Gunnarsson","Wikström","Holm","Samuelsson","Isaksson"
            ,"Fransson","Bergkvist","Nyström","Holmberg","Arvidsson","Lövgren","Söderberg","Nyberg","Ahmed","Blomqvist","Classon","Nordström","Hassan","Mårtensson","Lundström"
            ,"Viklund","Björklund","Eliasson","Berggren","Pålsson","Sandström","Nordin","Lund","Falk","Ström","Åberg","Ekström","Hermansson"};
            foreach (string name in ArrayNameList)
            {
                Guests.Add(new Persons(name));
                Console.WriteLine(name);
            }
         
        }
    }
    
    internal class Chefs : Persons
    {
        public Chefs(string name) : base(name)
        {

        }
        public static void CreatingChefs()
        {
            List<Persons> Chefs = new List<Persons>();
            string[] ChefNames = { "Mohammed", "Thom", "Bilal", "Daniel", "Erik", };
            foreach (string name in ChefNames)
            {
                Chefs.Add(new Persons(name));
                Console.WriteLine(name);
                
            }
        }
        // Kokens kompetens är en rating från 1-10
        public int Competence { get; set; }
        
    }
    internal class Waiters : Persons
    {
        public Waiters(string name) : base(name)
        {

        }
        public static void CreatingWaiter()
        {
            List<Persons> Waiters = new List<Persons>();
            string[] WaiterNames = { "Elias", "Emma", "Kenneth", };
            foreach(string name in WaiterNames)
            {
                Waiters.Add(new Persons(name));
                Console.WriteLine(name);

            }
        }

        // Servitörens Service level är en rating från 1-10
        public int ServiceLevel { get; set; }

    }
    internal class Guests : Persons
    {
        public Guests(string name) : base(name)
        {

        }

        public int GroupSize { get; set; }
        public int AmoutnOfMoney { get; set; }
        public bool Satisfaction { get; set; }

        //Ändrar på propen senare.
        //public bool Allergies { get; set; }
    }
}
