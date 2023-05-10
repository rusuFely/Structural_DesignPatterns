using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_DesignPatterns
{
    class CsvDataAdapter
    {
        private CsvFileReader _fileReader;

        public CsvDataAdapter(CsvFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public List<string[]> GetData()
        {
            return _fileReader.Read();
        }
    }

}
