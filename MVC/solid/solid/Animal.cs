using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    public class Animal:IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Fly()
        {
            
        }

        public void Run()
        {

        }
    }
}
