using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Section5
    {
        private readonly int _id = 0;
        private static int nextId = 1;

        public Section5(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
            this._id = nextId++;
        }

        public string Model { get; set; }
        public string Brand { get; set; }

        public int Id => _id;
    }
}
