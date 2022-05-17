using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item {
        public String name {get;}
        public int modVal {get;}
        public String modModded {get;}
        public Item(String name, int modVal, String modModded)
        {
                this.name = name;
                this.modVal = modVal;
                this.modModded = modModded;

        }
}

