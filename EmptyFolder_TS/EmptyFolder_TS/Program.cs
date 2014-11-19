using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace AutoBackup_TS
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>                                 //1
            {
                x.Service<Service>(s =>                        //2
                {
                    s.ConstructUsing(name => new Service());     //3
                    s.WhenStarted(tc => tc.Start());              //4
                    s.WhenStopped(tc => tc.Stop());               //5
                });
                x.RunAsLocalSystem();                            //6

                x.SetDescription("Service Description");        //7
                x.SetDisplayName("sName");                       //8
                x.SetServiceName("sName");                       //9
            });  
        }
    }
}
