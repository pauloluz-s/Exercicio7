using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public abstract class EraUmGaroto
    {
        protected abstract string Regiao { get; }

        public void Tocar()
        {
            Console.WriteLine("Era um garoto que como eu");
            VersaoBandasFavoritas();
            ViagemNoMundo();
            Console.WriteLine("As coisas lindas da " + Regiao);
        }

        protected abstract void VersaoBandasFavoritas();

        private void ViagemNoMundo()
        {
            Console.WriteLine("Girava o mundo sempre a cantar");
        }
    }
}
