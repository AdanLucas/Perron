namespace Repository.ScriptBase.Tabela
{
    internal class ScriptExecutado : IScriptTabela
    {
        public string GUID => "0A78123C-1FF4-44C2-8D4C-BC3C5142C83D";

        public string NomeTabela => "ScriptExecutado";

        public string Script
        {
            get
            {
                return $@"CREATE TABLE [dbo].[{NomeTabela}]
                        (
    						[GUID] [varchar](200) NOT NULL,
                            	[DataExecucao] [datetime] NULL,
                             CONSTRAINT [PK_ScriptExecutado] PRIMARY KEY CLUSTERED 
                            (
                            	[GUID] ASC
                            )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                            ) ON [PRIMARY]";
            }
        }
    }
}
