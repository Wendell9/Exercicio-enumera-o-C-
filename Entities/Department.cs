using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Resolvido_01_Enumeracao.Entities
{
    internal class Department
    {
       public String Name { get; set; }

        public Department()
        {
        }
        public Department(string name)
        {
            Name = name;
        }
    }
}
