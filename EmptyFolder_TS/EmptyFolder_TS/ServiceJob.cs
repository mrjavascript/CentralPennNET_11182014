using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using System.IO;

namespace AutoBackup_TS
{
    class ServiceJob : IJob
    {
        public ServiceJob()
        {
            
        }

        public void Execute(IJobExecutionContext context)
        {
            //
            //  UNCOMMENT AND BE CAREFUL
            //

            // Array.ForEach(Directory.GetFiles(@"C:\sample\"), File.Delete);
        }
    }
}
