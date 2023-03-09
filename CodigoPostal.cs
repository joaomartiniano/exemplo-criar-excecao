using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploCriarExcecao
{
    internal class CodigoPostal
    {
        public int Componente1 { get; set; } = 0;
        public int Componente2 { get; set; } = 0;

        public CodigoPostal(int componente1, int componente2)
        {
            Componente1 = componente1;
            Componente2 = componente2;

            ValidarCodigoPostal();
        }

        /// <summary>
        /// Valida um código postal. Gera uma exceção caso o código postal não seja válido.
        /// </summary>
        private void ValidarCodigoPostal()
        {
            if ((Componente1 < 1000) || (Componente1 > 9999))
            {
                throw new CodigoPostalInvalidoException("Código postal inválido", $"{Componente1}-{Componente2}");
            }

            if ((Componente2 < 1) || (Componente2 > 999))
            {
                throw new CodigoPostalInvalidoException("Código postal inválido", $"{Componente1}-{Componente2}");
            }
        }
    }
}
