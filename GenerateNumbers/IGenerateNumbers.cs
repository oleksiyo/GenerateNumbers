using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateNumbers
{
   public interface IGenerateNumbers
    {
        List<int> Generate(int start, int end);
    }
}
