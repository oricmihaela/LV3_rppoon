using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3_rppoon
{
    class RandomGenerator
    {
        private static RandomGenerator instance;
        private Random generator;
        private RandomGenerator()
        {
            this.generator = new Random();
        }
        public static RandomGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomGenerator();
            }
            return instance;
        } 
        
        public double[ , ] NextDouble(int n, int m)              //2. ZADATAK
        {
            double[,] randomMatrix = new double[n,m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    randomMatrix[n,m] = generator.NextDouble();
                }
            }
            return randomMatrix;
        }        //Kreirana je instanca instance i ona se jedina koristi, bez stvaranja novih.        //Odgovornosti: getter za instancu, defaultni konstruktor i metoda za popunjavanje matrice slucajnim brojevima.
    }
}
