using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class GarotoCaipira : EraUmGaroto
    {
        protected override string Regiao => "Inglaterra";

        protected override void VersaoBandasFavoritas()
        {
            Console.WriteLine("Amava Tonico e Tinoco e os Caipiras do Agreste");
        }
    }
}
