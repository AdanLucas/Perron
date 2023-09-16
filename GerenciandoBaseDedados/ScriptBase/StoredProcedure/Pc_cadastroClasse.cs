namespace Repository.ScriptBase.StoredProcedure
{
    internal class Pc_cadastroClasse : IScriptProcedure
    {
        public string GUID { get { return "8AE232B9-270F-4BAB-87FF-5A17F823B687"; } }
        public string Procedure { get { return "Pc_cadastroClasse"; } }

        public string ScriptPrcedured
        {
            get
            {
                return @"create procedure pc_cadastroClasse @id int,@descricao varchar(50),@ativo bit
                                as
                                BEGIN
                                
                                	IF(EXISTS(SELECT 1 FROM Classe WHERE ID = COALESCE(@id,0)))
                                	BEGIN
                                
                                	UPDATE CLASSE SET Descricao = @descricao,Ativo = @ativo WHERE Id = @id
                                
                                	END
                                
                                	ELSE
                                	BEGIN
                                
                                	INSERT INTO Classe (Descricao,Ativo)
                                				VALUES (@descricao,@ativo)
                                
                                	END
                                
                                
                                
                                END";
            }

        }
    }
}
