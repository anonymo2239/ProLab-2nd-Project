using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Transport : IReservable
    {
        public bool CheckSeatAvailability(int koltukNo)
        {
            // Koltuk durumunu kontrol et
            // Eğer müsaitse true döndür
            return true;
        }

        public void MakeReservation(int koltukNo)
        {
            // Rezervasyon yap
            // İşlemleri gerçekleştir
        }
    }
}
