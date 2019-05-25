using System;
using System.Collections.Generic;
using System.Text;

namespace EasyReport.Models
{
    public class LineSerie : ISerie
    {
        public string Type { get; } = "line";
        public List<decimal> Data; 
    }
}
