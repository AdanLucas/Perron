using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface.BancoDeDados
{
    public interface IScriptFunction
    {
        string GUID { get; set; }
        string Function { get;  set; }
        string ScriptFunction { get; }
    }
}
