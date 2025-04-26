using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Section5
    {
        public Section5(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public string Model { get; set; }
        public string Brand { get; set; }

    }
}
