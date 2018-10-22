using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask.Entities
{
    public class Pessoa
    {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        public virtual string senha { get; set; }
        public virtual string cpf { get; set; }
    }
}
