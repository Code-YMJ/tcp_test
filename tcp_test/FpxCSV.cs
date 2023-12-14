using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace tcp_test
{
    public class FpxCSV
    {
        private Stream stream;
        private string csvDir {  get; set; }
        private string csvFile { get { return string.Format("FpxCSV{0}", DateTime.Today.ToString("yyyy-MM-dd")); } }
        
        public FpxCSV() 
        {
            
        }
        public FpxCSV(string csvDir)
        {

        }

    }
}
