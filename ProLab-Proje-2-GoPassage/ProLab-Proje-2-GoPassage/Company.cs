using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Company : User , IProfitable 
    {
        // Company'e özgü işlevler...
        public override void Giris()
        {
            // Company giriş işlemleri...
        }
        // Company'e özgü diğer metodlar...
        public double CalculateDailyProfit()
        {
            // Günlük kar hesapla
            // Hesaplanan karı döndür
            return 32;
        }

        public double CalculateTotalProfit()
        {
            // Toplam karı hesapla
            // Hesaplanan karı döndür
            return 32;
        }
    }
}
