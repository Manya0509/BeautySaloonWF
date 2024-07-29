using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty.modals
{
    public static class Basket
    {
		public static List<PayingInfo> Items { get; set; } 
		
		private static int totalPrice;
		public static int TotalPrice
		{
			get 
			{
				int price = 0;

				foreach (var item in Items) 
				{
					price += item.Service.Price;		
				}

				totalPrice = price;

				return totalPrice; 	
			}
			set { totalPrice = value; }
		}


		static Basket()
		{
			int a = 0;
			Items = new List<PayingInfo>();
		}

		public static void AddOrder(string masterName, DateTime time, Service service)
		{ 
			PayingInfo payingInfo = new PayingInfo(masterName, time, service);
            
			Items.Add(payingInfo);
        }

	}
}
