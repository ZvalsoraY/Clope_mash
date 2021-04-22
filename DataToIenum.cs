using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Clope_mash
{
    class DataToIenum
    {
        public static IEnumerable<IEnumerable<string>> TransactionCharList(string filePath)
        {
            var lines = File.ReadLines(filePath);
            return lines.Select(line =>
              line.Split(new[] { ' ', '!', '?', ','}, StringSplitOptions.RemoveEmptyEntries).Select(s => s));
            
        }
    }
}
