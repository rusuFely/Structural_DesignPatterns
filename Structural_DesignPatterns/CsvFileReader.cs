using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_DesignPatterns
{
    class CsvFileReader
    {
        private string _fileName;

        public CsvFileReader(string fileName)
        {
            _fileName = fileName;
        }

        public List<string[]> Read()
        {
            List<string[]> data = new List<string[]>();

            using (StreamReader reader = new StreamReader(_fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    data.Add(fields);
                }
            }

            return data;
        }
    }

}
