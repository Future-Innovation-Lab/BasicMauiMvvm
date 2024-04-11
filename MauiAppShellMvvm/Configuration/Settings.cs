using MauiAppShellMvvm.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppShellMvvm.Configuration
{
    public class ExampleSettings : ISettings
    {
        public string ExampleServiceUrl { get => "Example of a Service to Connect to"; }
        public string SqliteDbName { get => "example.db"; }


    }
}
