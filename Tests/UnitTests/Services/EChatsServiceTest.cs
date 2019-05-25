using EasyReport;
using EasyReport.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnitTests.DependencyInjection;
using Xunit;

namespace UnitTests.Services
{
    public class EChatsServiceTest
    {
        private readonly IChartService _chartService;
        public EChatsServiceTest()
        {
            _chartService = _chartService.Resolve();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]

        public void FirstTest(int num)
        {
            var data = new List<decimal>()
            {
                GetNum(),
                GetNum(),
                GetNum(),
                GetNum(),
                GetNum(),
                GetNum(),
                GetNum()
            };

            var series = new List<ISerie>();

            var lineSerie = new LineSerie()
            {
                Data = data
            };
            series.Add(lineSerie);

            var x = new XAxis()
            {
                 Data = new List<string>()
                 {
                     "星期一",
                     "星期二",
                     "星期三",
                     "星期四",
                     "星期五",
                     "星期六",
                     "星期日"
                 }
            };

            var y = new YAxis();

            var option = new Option()
            {
                Series = series,
                XAxis = x,
                YAxis = y
            };

            var result = _chartService.GetHtmlChart(option);

            string saveUrl = Path.Combine(Environment.CurrentDirectory, $"{num}.html");

            File.WriteAllText(saveUrl, result);

        }
        public decimal GetNum()
        {
            Random random = new Random();
            var number = random.Next(1, 100);
            return decimal.Parse(number.ToString());
        }
    }
}
