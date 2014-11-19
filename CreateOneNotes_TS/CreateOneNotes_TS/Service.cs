using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace AutoBackup_TS
{
    public class Service : IService
    {
        private IScheduler sched;

        public Service()
        {
            sched = StdSchedulerFactory.GetDefaultScheduler();
        }

        public void Start()
        {
            Console.WriteLine(@"THIS PROGRAM SPAMS YOUR ONENOTE WITH POMPOUS NOTES ABOUT THE SPEAKER.  BE CAREFUL BEFORE RUNNING.");
            Console.WriteLine("Service Started");
            sched.Start();
            IJobDetail jobDetail = JobBuilder.Create<ServiceJob>().WithIdentity("serviceJob").Build();
            ITrigger trigger = TriggerBuilder.Create().WithIdentity("serviceTrigger")
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever())
                .Build();
            sched.ScheduleJob(jobDetail, trigger);
        }

        public void Stop()
        {
            sched.Shutdown();
            Console.WriteLine("Service Stopped");
        }
    }
}
