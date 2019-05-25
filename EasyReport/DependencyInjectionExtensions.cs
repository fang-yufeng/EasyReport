using EasyReport.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EasyReport
{
    public static class DependencyInjectionExtensions
    {
        public static void AddEasyReport(this IServiceCollection services)
        {
            services.AddTransient<IReportService, ReportService>();
        }
    }
}
