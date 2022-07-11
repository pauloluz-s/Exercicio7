using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class GarotoRock : EraUmGaroto
    {
        protected override string Regiao => "Argentina";

        protected override void VersaoBandasFavoritas()
        {
            Console.WriteLine("Amava o Sepultura e os Cavalera");
        }
    }
}
