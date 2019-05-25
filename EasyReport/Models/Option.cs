using System;
using System.Collections.Generic;
using System.Text;

namespace EasyReport.Models
{
    public class Option
    {
        public XAxis XAxis { get; set; }
        public YAxis YAxis { get; set; }
        public IEnumerable<ISerie> Series { get; set; }
    }
}
