using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class5
{
    internal class TPLDemo
    {
        public static async Task IndianFood()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Prepare Briyani with chicken 65 combo");
                    Task.Delay(100).Wait();
                }
            });
            
            
        }

        public static async Task ChineseFood()
        {
            for (int i = 0; i <= 5; i++)
            {
                await Task.Run(() =>
                {
                    Console.WriteLine("Prepare schzechew fired rice with some sauce");
                    Task.Delay(100).Wait();
                });
                
            }
        }
        public static void Continental()
        {
                for (int i = 0; i <= 5; i++)
                {
                 Console.WriteLine("Prepare pink sauce pasta with mushrooms");
                Task.Delay(200).Wait();
            }
        }
    }
}
