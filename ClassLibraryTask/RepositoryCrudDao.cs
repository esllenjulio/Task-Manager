using System;
using NHibernate;
using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask
{
     public class RepositoryCrudDao<T> : ICrudDAO<T> where T : class
    {
        public void Alterar(T entidade)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Erro ao alterar entidade:" + ex.Message);
                    }

                }
            }
        }


        public IList<T> Consultar()
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                return (from e in session.Query<T>() select e).ToList();
            }
        }

        public void Excluir(T entidade)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Erro ao Excluir entidade:" + ex.Message);
                    }

                }
            }
        }

        public void Inserir(T entidade)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw new Exception("Erro ao inserir entidade:" + ex.Message);
                    }

                }
            }
        }




        public T RetornarPorId(int id)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                return session.Get<T>(id);
            }
        }
    }
}
