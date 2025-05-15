using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_x_CraftingTable
{
    class receptek
    {
        public string itemName { get; set; }
        public int itemCount { get; set; }
        public List<int[,]> matrixok { get; set; }
        public receptek(string name, int count, List<int[,]> matrixok)
        {
            itemName = name;
            itemCount = count;
            this.matrixok = matrixok;
        }
        
        
    }
    //ctrl+shift+a
    
}
