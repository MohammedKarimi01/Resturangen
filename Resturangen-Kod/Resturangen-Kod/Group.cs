using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturangen_Kod
{
    public class Group
    {
        private int groupsize;

        public List<Person> Persons { get; set; }
        public Group()
        {
            
        }

        public Group(int groupsize)
        {
            this.groupsize = groupsize;
        }
    }
}
