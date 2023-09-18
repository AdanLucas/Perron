using System;
using System.Collections;
using System.Collections.Generic;

namespace Repository.Repository
{
    public class RepositoryBaseTipoPessoa : IReposotiryTipoPessoa
    {

        protected DbSession _session;

        protected virtual int Procedure(object cadastro) { return 0; }
        protected virtual object ScriptGetCadastroPorID(int Id) { return null; }
        protected virtual List<T> ScriptGetListaCadastrado<T>() { return null; }


        public object GetCadastroPorId(int Id)
        {
            using (_session = new DbSession())
            {
                return ScriptGetCadastroPorID(Id);
            }
        }
        public List<T> GetLista<T>()
        {
            using (_session = new DbSession())
            {
                return ScriptGetListaCadastrado<T>();
            }
        }
        public int Salvar(object cadastro)
        {
            using (_session = new DbSession())
            {
                try
                {
                    return Procedure(cadastro);
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }
        public void SalvarLista(IList lista)
        {
            using (_session = new DbSession())
            {
                try
                {
                    foreach (var item in lista)
                    {
                        Procedure(item);
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }
    }
}
