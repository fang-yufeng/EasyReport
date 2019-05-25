using EasyReport.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyReport.Models
{
    public class YAxis
    {
        public string Type { get; set; } = AxisType.value.ToString();
        public List<string> Data { get; set; }
    }
}
