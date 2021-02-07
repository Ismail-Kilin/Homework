using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer
{
    class GamerManager :IBaseGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {

            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.Check(gamer) == true)
            {
                Console.WriteLine("Kayıt Başarılı " + "İsim Soyisim : " + gamer.GamerName + gamer.GamerLastName +" Doğum tarihi: " +gamer.DateTime);
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt değiştirildi");
        }
    }
}
