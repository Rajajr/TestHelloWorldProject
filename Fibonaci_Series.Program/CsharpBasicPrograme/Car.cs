using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicPrograme
{
    public class Car
    {
        public string color;
        public string price;
        public string model;

    public void CarDetails()
        {
            Console.WriteLine("Carcolour={0} Carprice={1} Carmodel={2}", color, price,model);
        }
    }
}
