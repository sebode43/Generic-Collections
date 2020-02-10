using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Collections {
    class Customer {
        public int ID {get; set;}
        public string Name {get; set;} //type prop to get a template for properties
        public bool Active { get; set; } = true;

        public Customer(int ID, string Name, bool Active) {
            this.ID = ID;
            this.Name = Name;
            this.Active = Active;
        }

        public Customer() { }

    }
}
