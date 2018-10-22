using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTask;
using ClassLibraryTask.Entities;

namespace ClassLibraryTask
{
    public class UsuarioRepository : RepositoryCrudDao<Pessoa>
    {
        public bool ValidarAcesso(string cpf, string senha)
        {
           // Console.WriteLine(cpf);
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                return (from e in session.Query<Pessoa>() where e.cpf.Equals(cpf) && e.senha.Equals(senha) select e).Count() > 0;
            }
        }
    }
}
