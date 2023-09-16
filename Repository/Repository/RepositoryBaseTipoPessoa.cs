using System;
using System.Collections;

namespace Repository.Repository
{
    public class RepositoryBaseTipoPessoa : IReposotiryTipoPessoa
    {

        protected DbSession _session;

        protected virtual int Procedure(object cadastro) { return 0; }
        protected virtual object ScriptGetCadastroPorID(int Id) { return null; }
        protected virtual IList ScriptGetListaCadastrado() { return null; }


        public object GetCadastroPorId(int Id)
        {
            using (_session = new DbSession())
            {
                return ScriptGetCadastroPorID(Id);
            }
        }
        public IList GetLista()
        {
            using (_session = new DbSession())
            {
                return ScriptGetListaCadastrado();
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
