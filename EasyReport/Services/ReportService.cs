using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using EasyReport.Models;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EasyReport.Services
{
    public class ReportService : IReportService
    {
        public string GetHtml(Option option)
        {
            var templateUrl = Path.Combine(Environment.CurrentDirectory, "Resources", "template.html");

            var templateHtml = File.ReadAllText(templateUrl);

            var optionsString = JsonConvert.SerializeObject(option,
                new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                });

            var result = templateHtml.Replace("optionString", optionsString);

            return result;
        }

        public Option GetLine<TData, TXAxis, TSerie>(IEnumerable<TData> data, Expression<Func<TData, TXAxis>> xAxisData, Expression<Func<TData, TSerie>> serieData)
        {
            throw new NotImplementedException();
        }

        public Option GetLine<TData, TXAxis, TSerie1, TSerie2>(IEnumerable<TData> data, Expression<Func<TData, TXAxis>> xAxisData, Expression<Func<TData, TSerie1>> serieData1, Expression<Func<TData, TSerie2>> serieData2)
        {
            throw new NotImplementedException();
        }

        public Option GetLine<TData, TXAxis, TSerie1, TSerie2, TSerie3>(IEnumerable<TData> data, Expression<Func<TData, TXAxis>> xAxisData, Expression<Func<TData, TSerie1>> serieData1, Expression<Func<TData, TSerie2>> serieData2, Expression<Func<TData, TSerie3>> serieData3)
        {
            throw new NotImplementedException();
        }
    }
}
