using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using EasyReport.Models;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EasyReport.Services
{
    public class EChartsService : IChartService
    {
        public string GetHtmlChart(Option option)
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
    }
}
