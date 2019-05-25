using EasyReport.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyReport
{
    public interface IChartService
    {
        string GetHtmlChart(Option option);
    }
}
