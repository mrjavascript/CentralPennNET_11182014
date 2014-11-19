using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using System.IO.Compression;

namespace AutoBackup_TS
{
    class ServiceJob : IJob
    {
        public ServiceJob()
        {
        }

        public void Execute(IJobExecutionContext context)
        {
            ZipFile.CreateFromDirectory(@"C:\sample", String.Format("C:\\sample_out\\sample_{0}.zip", DateTime.Now.Ticks));
        }
    }
}
