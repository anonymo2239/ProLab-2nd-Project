using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal abstract class User : ILoginable
    {
        public bool Giris(string username, string password)
        {
            // Kullanıcı adı ve şifre doğrulaması yap
            // Eğer doğruysa true döndür
            return true;
        }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        // Ortak metodlar
        public abstract void Giris();
        // Diğer ortak metod ve değişkenler...
    }
}
