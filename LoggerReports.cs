using BookLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalManager
{
    public class LoggerReports : LogBase
    {
        private string CurrenDirectory { get; set; }
        private string FileName { get; set; }
        private string FilePath { get; set; }

        public LoggerReports()
        {
            this.CurrenDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Reports.txt";
            this.FilePath = this.CurrenDirectory + "/" + this.FileName;
        }

        public override void WriteLog(string message)
        {
            DbService dbService = new DbService("Inventories.json");
            message = dbService.ToString();
            using (StreamWriter sw = File.AppendText(this.FilePath))
            {
                sw.Write("\r\nReport: ");
                sw.WriteLine($"{DateTime.Now} : \n{message}");
                sw.WriteLine("--------------------------------------------------------------------");
            }
        }
    }
}
