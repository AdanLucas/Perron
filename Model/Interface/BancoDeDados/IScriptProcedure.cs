using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IScriptProcedure
{
    string GUID { get; set; }
    string Prcedure { get; set; }
    bool ScriptPrcedured(IDbConnection Connection);
}

