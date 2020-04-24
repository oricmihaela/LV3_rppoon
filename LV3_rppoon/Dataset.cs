using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3_rppoon
{
    class Dataset : IPrototype
    {
        private List<List<string>> data; 
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
                new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }

        public IPrototype Clone()                                   //1. ZADATAK
        {
            Dataset deepCopy = new Dataset();  //stvaranje novog objekta koji ce biti kopija

            for (int i = 0; i < data.Count(); i++)
            {
                deepCopy.data.Add(new List<string>());
                for (int j = 0; j < data[i].Count(); j++)
                {
                    deepCopy.data[i].Add(data[i][j]);
                }
            }

            return deepCopy;
        }
    }
}
