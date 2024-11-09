using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TfLJourneyPlanner
{
    public class ConfigurationSetting
    {
        public IConfiguration _configuration;

        public ConfigurationSetting()
        {
            _configuration = GetConfiguration();
        }

        public IConfiguration Configuration => _configuration;

        //public IConfiguration Configuration { get; }

        //public ConfigurationSetting(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public void ConfigurationServices(IServiceProvider services)
        //{
        //    var env =  Configuration["Environment"];
        //}

        public string? env => Configuration["Environment"];


        private IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder();
            string directoryName = Path.GetDirectoryName(typeof(ConfigurationSetting).Assembly.Location);
            builder.AddJsonFile(Path.Combine(directoryName, @"jsconfig1.json"), optional: false, reloadOnChange: true);
            return builder.Build();

        }

    }
}

