using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace _11_x_CraftingTable
{
    class fileManager
    {
        public List<receptek> beolvas(string fileName)
        {
            List<receptek> temp = new List<receptek>();
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return temp;
        }
    }
}
