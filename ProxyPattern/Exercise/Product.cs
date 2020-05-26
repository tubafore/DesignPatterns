using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public abstract class Product
    {
        protected int id;
        protected string name;

        public Product(int id)
        {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
        }

        public abstract string Name
        {
            get;
            set; 
        }
    }
}
