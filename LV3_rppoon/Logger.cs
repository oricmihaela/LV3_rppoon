using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3_rppoon
{
    class Logger                              //3. ZADATAK
    {
        private static Logger instance;
        private string fileName;

        private Logger(string fileName)
        {
            this.fileName = fileName;
        }
       public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger("ProtectedFile.txt");
            }
            return instance;
        }
        public void FileLogger(string content)
        {
            using (System.IO.StreamWriter fileWriter = new System.IO.StreamWriter(this.fileName, true))
            {
                fileWriter.WriteLine(content);
            }
        }
    }
}
