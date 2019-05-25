using EasyReport.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyReport.Models
{
    public class XAxis
    {
        public string Type { get; set; } = AxisType.category.ToString();
        public List<string> Data { get; set; }
    }
}
