using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer
{
    interface IBaseGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);

    }
}
