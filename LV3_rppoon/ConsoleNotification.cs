using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3_rppoon
{
    public enum Category { ERROR, ALERT, INFO }
    public class ConsoleNotification : IPrototype
    {
        public String Author { get; private set; }
        public String Title { get; private set; }
        public String Text { get; private set; }
        public DateTime Timestamp { get; private set; }
        public Category Level { get; private set; }
        public ConsoleColor Color { get; private set; }
        public ConsoleNotification(String author, String title,
        String text, DateTime time, Category level, ConsoleColor color)
        {
            this.Author = author;
            this.Title = title;
            this.Text = text;
            this.Timestamp = time;
            this.Level = level;
            this.Color = color;
        }

        //7.ZADATAK
        IPrototype IPrototype.Clone()
        {
            throw new NotImplementedException();
        }
        /*U ovom primjeru postoji razlika u plitkom i dubokom kopiranju jer ce se bilo kakvom promijenom 
         na kopiranoj notifikaciji promijeniti i izvorna iako bismo mozda nju htjeli ostaviti kakva je.*/

    }
}
