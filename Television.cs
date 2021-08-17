using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    class Television
    {
        public string name;
        public double rating;
        private Television television;

        public Television()
        {
        }
        
        public Television(Television television)
        {
            this.television = television;
        }

        public Television(string name, double rating)
        {
            this.name = name;
            this.rating = rating;
        }

        public string Name { get => name; set => name = value; }
        public double Rating { get => rating; set => rating = value; }
    }
}
