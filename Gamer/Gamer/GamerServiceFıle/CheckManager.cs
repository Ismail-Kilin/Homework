using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer
{
    class CheckManager : IGamerCheckService
    {
        public bool Check(Gamer Gamer)
        {
            if(Gamer.DateTime== 1999&& Gamer.GamerName=="İsmail"&& Gamer.GamerLastName == "Kılın" && Gamer.NationalId == 123564)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
