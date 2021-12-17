using System;
using System.IO;

namespace c08_2Interface
{
    /*interface ILogger
      {
          void WriteLog(string message);
      }

      class ConsoleLogger : ILogger//사용안한 클래스???
      {
          public void WriteLog(string message)
          {
              Console.WriteLine(
                  "{0} {1}", DateTime.Now.ToLocalTime(), message  );
          }
      }

      class FileLogger : ILogger
      {
          private StreamWriter writer;

          public FileLogger(string path)
          {
              writer = File.CreateText(path);
              writer.AutoFlush = true;
          }

          public void WriteLog(string message)
          {
              writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
          }
      }

      class ClimateMonitor
      {
          private ILogger logger;
          public ClimateMonitor(ILogger logger)
          {
              this.logger = logger;
          }

          public void start()
          {
              while (true)
              {
                  Console.Write("온도를 입력해주세요 : ");
                  string temperature = Console.ReadLine();
                  if (temperature == "")
                      break;

                  logger.WriteLog("현재 온도 : " + temperature);
              }
          }
      }

      class MainApp
      {
          static void Main(string[] args)
          {
              ClimateMonitor monitor = new ClimateMonitor(
                  new FileLogger(@"C:\Users\dnedr\Desktop\githurb\Csharp-study\09property\09property\MyLog.txt"));
              monitor.start();
          }
      }

      */
}
