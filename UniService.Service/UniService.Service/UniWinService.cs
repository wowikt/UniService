using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace UniService.Service
{
    public partial class UniWinService : ServiceBase
    {
        public ServiceHost serviceHost = null;
        
        public UniWinService()
        {
            ServiceName = "UniService";
            InitializeComponent();
            ServiceLog = new EventLog();
            if (!EventLog.SourceExists("UniServiceSource"))
            {
                EventLog.CreateEventSource("UniServiceSource", "UniServiceLog");
            }

            ServiceLog.Source = "UniServiceSource";
            ServiceLog.Log = "UniServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create a ServiceHost for the CalculatorService type and
            // provide the base address.
            serviceHost = new ServiceHost(typeof(Business.Services.UniService));

            // Open the ServiceHostBase to create listeners and start
            // listening for messages.
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
