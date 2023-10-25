using System;
using System.Threading;

namespace ClickShow
{
    internal static class Program
    {
        static Mutex mutex;
        static string mutexName = "{3032D362-2184-47B6-9B8D-17413D7DF138}";

        [STAThread]
        static void Main()
        {
            Program.mutex = new Mutex(true, mutexName, out var createNew);

            if (createNew)
            {
                var app = new App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}
