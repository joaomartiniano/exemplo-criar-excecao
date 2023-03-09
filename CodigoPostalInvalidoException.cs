using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCriarExcecao
{
    [Serializable]
    public class CodigoPostalInvalidoException : Exception
    {
        public string CodigoPostal { get; }

        public CodigoPostalInvalidoException()
        { }

        public CodigoPostalInvalidoException(string message) : base(message)
        { }

        public CodigoPostalInvalidoException(string message, Exception inner)
            : base(message, inner)
        { }

        public CodigoPostalInvalidoException(string message, string codigoPostal)
            : this(message)
        {
            CodigoPostal = codigoPostal;
        }
    }
}
