using Beauty;
using Beauty.modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloon
{
    public class BeautyMaster
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkExperience { get; set; }
        public string Profession { get; set; }
        public RegistrationTime[] Times { get; set; } = new RegistrationTime[8];
        public List<Service> Services { get; set; }
        public string ImagePath { get; set; }

        public BeautyMaster(string name, int age, int workExperience, string profession, string imagePath)
        {
            Name = name;
            Age = age;
            WorkExperience = workExperience;
            Profession = profession;
            ImagePath = imagePath;

            Services = new List<Service>();

            InitWorkTimes();
        }

        private void InitWorkTimes()
        {
            var today = DateTime.Now;

            for (int i = 0; i < Times.Length; i++)
            {
                Times[i] = new RegistrationTime { Time = new DateTime(today.Year, today.Month, today.Day, 8 + i, 0, 0) };
            }
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Имя мастера: " +  Name + ", возраст: " + Age + ", стаж работы: " + WorkExperience + ", профессия: " + Profession);
        }

        public void AddServices(Service[] services)
        {
            Services.AddRange(services);
        }

        public void RemoveServices(Service[] services)
        {
            for (int i = 0; i < services.Count(); i++) 
            {
                Services.Remove(services[i]);
            }
        }

        public void ChangeServicePrice(string serviceName, int newPrice)
        {
            Service service = Services.FirstOrDefault(x => x.Name == serviceName);

            if (service != null)
            {
                service.Price = newPrice;
            }

            //for(int i = 0;i < Services.Count(); i++)
            //{
            //    if (Services[i].Name == serviceName)
            //    {
            //        Services[i].Price = newPrice;  
            //    }
            //}
        }

    }
}
