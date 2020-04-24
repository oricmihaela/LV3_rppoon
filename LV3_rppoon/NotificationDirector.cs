using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3_rppoon
{
    //6. ZADATAK
    //enum vec postoji s pravom public
    class NotificationDirector
    {
        public ConsoleNotification AlertNotification(string author)
        {
            return new ConsoleNotification(author, "New message", "empty", DateTime.Now, Category.ALERT, ConsoleColor.Blue);
        }
        public ConsoleNotification InfoNotification(string author)
        {
            return new ConsoleNotification(author, "New message", "empty", DateTime.Now, Category.INFO, ConsoleColor.Blue);
        }
        public ConsoleNotification ErrorNotification(string author)
        {
            return new ConsoleNotification(author, "New message", "empty", DateTime.Now, Category.ERROR, ConsoleColor.Blue);
        }
    }
}
