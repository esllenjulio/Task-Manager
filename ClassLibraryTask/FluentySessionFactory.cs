
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
    public class FluentySessionFactory
    {
        private static string ConnectionString = "Server=127.0.0.1;Port=3306;Database=db_teste;Uid=root;Pwd=159753;";

        private static ISessionFactory session;
        public static ISessionFactory CriarSession()
        {
            if (session != null)
            {
                return session;
            }

            IPersistenceConfigurer configDB = MySQLConfiguration.Standard.ConnectionString(ConnectionString);
            var configMap = Fluently.Configure().Database(configDB).Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapping.PessoaMap>());
            session = configMap.BuildSessionFactory();
            return session;

        }

        public static ISession AbrirSession()
        {
            return CriarSession().OpenSession();
        }
    }
}
