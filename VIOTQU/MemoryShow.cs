using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIOTQU
{
    /// <summary>
    /// converter memory size to text
    /// </summary>
 public   class MemoryShow : IDisposable
    {
        public void Dispose()
        {
           
        }
        /// <summary>
        /// get string info RAM with size RaM
        /// </summary>
        /// <param name="value">RAM value</param>
        /// <returns></returns>
        public string GetStringRAM (double value)
        {
           
            string sizeName = "KB";
            // size value
            double fres = 0;
            // if size RAM greater than MB
           if (value >= 1024)
            {
                sizeName = "MB";
                 fres = Math.Round(value / 1024, 2);
            }
            // if size RAM greater than GB
            if (value >= 1024 * 1024)
            {
                fres = Math.Round(value / (1024 * 1024), 2);
                sizeName = "GB";
            }
            // if size RAM greater than tb
            if (value >= 1024 * 1024 * 1024)
            {
                fres = Math.Round(value / (1024 * 1024 * 1024), 2);
                sizeName = "TB";
            }
            // return string RAM: example: 8 GB
            return fres + " " + sizeName;
        }
    }
}
