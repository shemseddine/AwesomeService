using AwesomeService.Core;

namespace AwesomeService.WindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new AppRunner();
            runner.Start();
            while (runner.IsRunning)
            {
            }
        }
    }
}
