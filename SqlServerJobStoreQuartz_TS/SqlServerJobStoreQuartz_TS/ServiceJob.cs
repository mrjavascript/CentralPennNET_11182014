using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using System.IO.Compression;
using Common.Logging;

namespace SqlServerJobStoreQuartz_TS
{
    class ServiceJob : IJob
    {
        private static ILog logging = LogManager.GetLogger(typeof(ServiceJob));

        public ServiceJob()
        {
        }

        public void Execute(IJobExecutionContext context)
        {
            logging.InfoFormat("Hello from job!");
        }
    }
}
