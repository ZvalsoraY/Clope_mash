using System;
using System.Collections.Generic;
using System.Text;

namespace Clope_mash
{
    class DataToIenum
    {
        public static IEnumerable<IEnumerable<double>> FileDoubleArrayList(string filePath)
        {
            var lines = File.ReadLines(filePath);
            //return lines.Select(line =>
            //  line.Split(new[] { ' ', '!' }, StringSplitOptions.RemoveEmptyEntries).Select(s =>
            //      double.Parse(s, NumberStyles.Any, CultureInfo.InvariantCulture))).OrderBy(u => u.ElementAt(1));
            return lines.Select(line =>
              line.Split(new[] { ' ', '!' }, StringSplitOptions.RemoveEmptyEntries).Select(s =>
              Math.Round(double.Parse(s, NumberStyles.Any, CultureInfo.InvariantCulture), 2, MidpointRounding.AwayFromZero)
                  )).OrderBy(u => u.ElementAt(1));
        }
    }
}
