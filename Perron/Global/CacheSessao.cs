using System;
using System.Collections.Generic;
using System.Threading.Tasks;



public class CacheSessao
{

    public List<PessoaModel> ListaPessoa {  get; set; }
    public static CacheSessao Instancia
    {
        get
        {
            if (instance == null)
                instance = new CacheSessao();


            return instance;
        }
    }
    private static CacheSessao instance;
    private IServiceBancoDeDados _serviceBancodedados;

    private CacheSessao()
    {
        _serviceBancodedados = FactoryService.BancoDados();
    }
    public async Task Iniciar()
    {
        try
        {
            ConfiguracaoInicial.Instancia.Iniciar();
            await _serviceBancodedados.RealizarVerificacaoBancoDados();

        }
        catch (Exception ex)
        {

            throw ex;
        }




    }
}

