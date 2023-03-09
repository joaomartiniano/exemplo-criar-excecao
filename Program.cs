using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCriarExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar um código válido.
            CodigoPostal codigoPostal1 = new CodigoPostal(3040, 087);

            // Criar um código postal inválido.
            // Irá gerar uma exceção.
            CodigoPostal codigoPostal2 = new CodigoPostal(31233, 450);

            Console.ReadKey();
        }
    }
}
