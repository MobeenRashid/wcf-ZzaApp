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
using Zza.Services;

namespace ZzaServiceHost
{
    public partial class ZzaServiceHost : ServiceBase
    {
        private ServiceHost _serviceHost;
        public ZzaServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _serviceHost = new ServiceHost(typeof (ZzaService));
            _serviceHost.Open();
        }

        protected override void OnStop()
        {
            _serviceHost.Close();
        }
    }
}
