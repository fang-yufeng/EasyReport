using EasyReport.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EasyReport
{
    public interface IReportService
    {
        Option GetLine<TData, TXAxis, TSerie>(IEnumerable<TData> data, Expression<Func<TData, TXAxis>> xAxisData, Expression<Func<TData, TSerie>> serieData);
        Option GetLine<TData, TXAxis, TSerie1, TSerie2>(IEnumerable<TData> data, Expression<Func<TData, TXAxis>> xAxisData, Expression<Func<TData, TSerie1>> serieData1, Expression<Func<TData, TSerie2>> serieData2);
        Option GetLine<TData, TXAxis, TSerie1, TSerie2,TSerie3>(IEnumerable<TData> data, Expression<Func<TData, TXAxis>> xAxisData, Expression<Func<TData, TSerie1>> serieData1, Expression<Func<TData, TSerie2>> serieData2, Expression<Func<TData, TSerie3>> serieData3);
    }
}
