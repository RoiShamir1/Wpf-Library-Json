using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalManager
{
    public class Logger : LogBase
    {
        private string CurrenDirectory { get; set; }
        private string FileName { get; set; }
        private string FilePath { get; set; }

        public Logger()
        {
            this.CurrenDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrenDirectory + "/" + this.FileName;
        }

        public override void WriteLog(string message)
        {
            using (StreamWriter sw = File.AppendText(this.FilePath))
            {
                sw.Write("\r\nLog Entry: ");
                sw.WriteLine($"{DateTime.Now} : {message}");
                sw.WriteLine("--------------------------------------------------------------------");
            }
        }
    }
}
