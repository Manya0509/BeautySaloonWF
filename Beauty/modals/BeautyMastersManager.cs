using BeautySaloon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty.modals
{
    public static class BeautyMastersManager
    {
        public static List<BeautyMaster> Masters { get; set; }

        static BeautyMastersManager()
        {
            Masters = new List<BeautyMaster>();

            Init();
        }

        private static void Init()
        {
            BeautyMaster barber = new BeautyMaster("Виктория", 20, 2, "Барбер");
            barber.AddServices(new Service[] { new Service("Стрижка женская", 2000), new Service("Стрижка мужская", 1000) });
            BeautyMaster barber1 = new BeautyMaster("Евгения", 22, 3, "Барбер");
            barber1.AddServices(new Service[] { new Service("Окрашивание волос", 4000), new Service("Наращивание волос", 7000) });
            BeautyMaster visagiste = new BeautyMaster("Екатерина", 25, 6, "Визажист");
            visagiste.AddServices(new Service[] { new Service("Окрашивание бровей", 700), new Service("Дневной макияж", 2000), new Service("Вечерний макияж", 3000) });
            BeautyMaster visagiste1 = new BeautyMaster("Александра", 29, 4, "Визажист");
            visagiste1.AddServices(new Service[] { new Service("Пробный свадебный образ", 2500), new Service("Свадебный образ", 5000) });
            BeautyMaster lashmaker = new BeautyMaster("Кристина", 23, 1, "Лэшмейкер");
            lashmaker.AddServices(new Service[] { new Service("Наращивание ресниц", 1500), new Service("Ламинирование ресниц", 1200), new Service("Снятие ресниц", 200) });
            BeautyMaster cosmetologist = new BeautyMaster("Валерия", 32, 10, "Косметолог");
            cosmetologist.AddServices(new Service[] { new Service("Консультация специалиста", 0), new Service("Чистка лица", 4000), new Service("Массаж лица", 2500), new Service("Пилинг", 1500) });


            Masters.AddRange( new BeautyMaster[] { barber, visagiste, lashmaker, cosmetologist, barber1, visagiste1 });
        }
    }
}
