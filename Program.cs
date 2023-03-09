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
            CodigoPostal codigoPostal1, codigoPostal2;

            try
            {
                // Criar um código postal válido
                codigoPostal1 = new CodigoPostal(3040, 087);
            }
            catch (CodigoPostalInvalidoException excecao)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar criar o código postal {excecao.CodigoPostal}");
            }

            try
            {
                // Criar um código postal inválido
                // Irá gerar uma exceção
                codigoPostal2 = new CodigoPostal(31233, 450);
            }
            catch (CodigoPostalInvalidoException excecao)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar criar o código postal {excecao.CodigoPostal}");
            }

            Console.ReadKey();
        }
    }
}
