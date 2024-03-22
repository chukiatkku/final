using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class CSV
    {
        private string path = @"C:\IN401105\project - Copy - Copy\project\data.csv";

        public bool SavetoFile(Animal animal)
        {
            string contents = animal.name + "," + animal.gene + "," + animal.price+"\n";
            try
            {
                File.AppendAllText(path, contents);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
