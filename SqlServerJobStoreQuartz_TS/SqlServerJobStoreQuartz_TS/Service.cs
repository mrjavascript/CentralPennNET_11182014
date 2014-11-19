using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;

namespace SqlServerJobStoreQuartz_TS
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
            var ticks = DateTime.Now.Ticks;
            Console.WriteLine("Service Started");
            sched.Start();
            IJobDetail jobDetail = JobBuilder.Create<ServiceJob>().WithIdentity("serviceJob_" + ticks).Build();
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("serviceTrigger_" + ticks, "serviceGroup_" + ticks)
                .WithSimpleSchedule(x => x.WithIntervalInSeconds(10).RepeatForever())
                .Build();
            sched.ScheduleJob(jobDetail, trigger);
        }

        public void Stop()
        {
            sched.Shutdown(true);
            Console.WriteLine("Service Stopped");
        }
    }
}
