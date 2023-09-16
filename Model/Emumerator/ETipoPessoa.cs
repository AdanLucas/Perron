using System;

namespace Model.Emumerator
{
    [Flags]
    public enum ETipoPessoa : long
    {
        [EComando(
            Repository = "Repository.Repository.RepositoryPessoa",
            Controller = "Perron.Controller.ControllerTipoPessoa",
            Service = "Services.Service.ServiceTipoPessoa")]
        Pessoa = 0,

        [EComando(
            Repository = "Repository.Repository.RepositoryPessoaTipoFuncionario",
            Controller = "Perron.Controller.ControllerTipoFuncionario",
            Service = "Services.Service.ServiceTipoPessoa")]
        Funcionario = 1,

        [EComando(
            Repository = "Repository.Repository.RepositoryPessoaTipoCliente",
            Controller = "Perron.Controller.ControllerTipoCliente",
            Service = "Services.Service.ServiceTipoPessoa")]
        Cliente = 2,

        [EComando(
            Repository = "Repository.Repository.RepositoryPessoaTipoEmpresa",
            Controller = "Perron.Controller.ControllerTipoEmpresa",
            Service = "Services.Service.ServiceTipoPessoa")]
        Empresa = 8,
    }
}
