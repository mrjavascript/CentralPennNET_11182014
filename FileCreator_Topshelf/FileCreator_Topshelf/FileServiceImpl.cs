using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace FileCreator_Topshelf
{
    public class FileServiceImpl : FileService
    {
        private Timer t;
        public FileServiceImpl()
        {
            t = new Timer();
        }

        public void Start()
        {
            t.Elapsed += new ElapsedEventHandler(FileCreateEvent);
            t.Interval = 5000;
            t.Enabled = true;
        }

        public void Stop()
        {
            t.Stop();
        }

        private static void FileCreateEvent(object source, ElapsedEventArgs e)
        {
            File.Create(String.Format("C:\\sample\\hello_{0}.txt", DateTime.Now.Ticks));
        }
    }
}
