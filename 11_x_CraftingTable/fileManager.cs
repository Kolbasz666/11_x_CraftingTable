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
                StreamReader read = new StreamReader(fileName, Encoding.UTF8);
                while (!read.EndOfStream)
                {
                    string[] nameAndCount = read.ReadLine().Split(';');
                    string[] matrixok = read.ReadLine().Split(';');
                    string name = nameAndCount[0];
                    int count = int.Parse(nameAndCount[1]);
                    List<int[,]> matrixInt = new List<int[,]>();
                    foreach (string item in matrixok)
                    {
                        int[,] matrix = new int[3, 3];
                        string[] sorok = item.Split(',');
                        for (int row = 0; row < 3; row++)
                        {
                            for (int col = 0; col < 3; col++)
                            {
                                matrix[row, col] = int.Parse(sorok[row][col].ToString());
                            }
                        }
                        matrixInt.Add(matrix);
                    }
                    temp.Add(new receptek(name, count, matrixInt));
                }
                read.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return temp;
        }
    }
}
