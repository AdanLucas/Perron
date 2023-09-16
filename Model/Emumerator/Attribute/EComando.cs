using System;

namespace Model.Emumerator
{

    [AttributeUsageAttribute(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    [Serializable]
    public sealed class EComando : Attribute
    {
        public string Repository { get; set; }
        public string Controller { get; set; }
        public string Service { get; set; }
    }
}
