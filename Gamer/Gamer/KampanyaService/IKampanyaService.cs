using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer
{
    interface IKampanyaService
    {
        void KampanyaAdd(Kampanya kampanya);
        void KampanyaDelete(Kampanya kampanya);
        void KampanyaUpdate(Kampanya kampanya);

    }
}
