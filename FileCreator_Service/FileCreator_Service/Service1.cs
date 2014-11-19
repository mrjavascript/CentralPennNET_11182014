using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace FileCreator_Service
{
    public partial class Service1 : ServiceBase
    {
        private Timer t;
        public Service1()
        {
            t = new Timer();
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            t.Elapsed += new ElapsedEventHandler(FileCreateEvent);
            t.Interval = 5000;
            t.Enabled = true;
        }

        protected override void OnStop()
        {
            t.Stop();
        }

        private static void FileCreateEvent(object source, ElapsedEventArgs e)
        {
            File.Create(String.Format("C:\\sample\\hello_{0}.txt", DateTime.Now.Ticks));
        }
    }
}
