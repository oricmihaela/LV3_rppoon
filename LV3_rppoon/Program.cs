using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3_rppoon
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. ZADATAK testiranje
            Dataset originalDataset = new Dataset("csv.txt");                     
            Dataset copiedDataset = (Dataset)originalDataset.Clone();

            //ispis kopije originalDataset
            for(int i = 0; i < copiedDataset.GetData().Count; i++)
            {
                for(int j = 0; j < copiedDataset.GetData()[i].Count; j++)
                {
                    Console.Write(copiedDataset.GetData()[i][j]);
                }
                Console.WriteLine();
            }


            //4. ZADATAK
            ConsoleNotification newNotification = new ConsoleNotification("Mum", "New message!", "I'm coming home early!", DateTime.Now, Category.INFO, ConsoleColor.Red);
            NotificationManager manager = new NotificationManager();
            manager.Display(newNotification);
            
        }
    }
}
