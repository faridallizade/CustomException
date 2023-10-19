using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExcp
{
    internal class Human
    {
        public string Name { get; set; }
        public string Surname{ get; set; }
        private int _age;

        
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new AgeException("Age is not zero or negative");
                }
                _age = value;
            }
        }
        public Human(string Name,string Surname,int Age)
        {
                    this.Name = Name;
                    this.Surname = Surname;
                    this.Age = Age;
        }
    }
}
