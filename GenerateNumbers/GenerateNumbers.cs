using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateNumbers
{
    public class GenerateNumbers
    {
        public List<int> Generate(int start, int end)
        {
            return Enumerable.Range(start, end).ToList();
        }
    }
}
