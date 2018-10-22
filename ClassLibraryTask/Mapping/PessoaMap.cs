using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask.Entities;
using FluentNHibernate.Mapping;
namespace ClassLibraryTask.Mapping
{
    public class PessoaMap : ClassMap<Pessoa>
    {
        public PessoaMap()
        {
            Id(p => p.id);
            Map(p => p.nome);
            Map(p => p.senha);
            Map(p => p.cpf);
            Table("Pessoa");
        }
    }
}
