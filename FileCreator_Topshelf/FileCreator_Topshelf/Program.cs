using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;
using System.Threading;

namespace FileCreator_Topshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>                                 //1
            {
                x.Service<FileServiceImpl>(s =>                        //2
                {
                    s.ConstructUsing(name => new FileServiceImpl());     //3
                    s.WhenStarted(tc => tc.Start());              //4
                    s.WhenStopped(tc => tc.Stop());               //5
                });
                x.RunAsLocalSystem();                            //6

                x.SetDescription("This service creates a number of files in your C: drive");        //7
                x.SetDisplayName("File Creator Service");                       //8
                x.SetServiceName("File_Creator_Service");                       //9
            });

            Thread.Sleep(5000);
        }
    }
}
