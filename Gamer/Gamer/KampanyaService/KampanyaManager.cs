using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.KampanyaService
{
    class KampanyaManager : IKampanyaService
    {
        public void KampanyaAdd(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya eklendi "+ kampanya.KampanyaName +"Kampanya Id number:" + kampanya.KampanyaId);
        }

        public void KampanyaDelete(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya silindi"); ;
        }

        public void KampanyaUpdate(Kampanya kampanya)
        {
            Console.WriteLine("Kampanya değişti"); ; ;
        }
    }
}
