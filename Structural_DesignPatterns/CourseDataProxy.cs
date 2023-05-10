using LearningSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_DesignPatterns
{
    class CourseDataProxy : ICourseData
    {
        private CsvDataAdapter _dataAdapter;
        private List<string[]> _data;

        public CourseDataProxy(CsvDataAdapter dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }

        public List<string[]> GetData()
        {
            if (_data == null)
            {
                Console.WriteLine("Loading course data...");
                _data = _dataAdapter.GetData();
            }

            return _data;
        }
    }
}
