using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal
            {
                Name = "企鵝",
                Age = 10
            };
            var animal1 = CreateBird("鸚鵡", 2, "Bird");



        }
        public static Animal CreateBird(string name, int age, string animal)
        {
            Animal a = null;
            if (!string.IsNullOrWhiteSpace(animal))
            {
                switch (animal)
                {
                    case "bird":
                        a = new Bird
                        {
                            Name = name,
                            Age = age
                        };
                        break;
                    case "Dog":
                        a = new Dog
                        {
                            Name = name,
                            Age = age
                        };
                        break;
                    default:
                        break;
                }
            }
            return a;
        }
    }
}
