using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class ProductProxy : Product
    {
        public DbContext context { get; set; }

        private ProductProxy(int id) : base(id)
        {

        }

        public ProductProxy(int id, DbContext context) : this(id)
        {
            this.context = context;
        }

        public override string Name
        {
            get { return name; }
            set
            {
                name = value;
                context.MarkAsChanged(this);
            }
        }
    }
}
