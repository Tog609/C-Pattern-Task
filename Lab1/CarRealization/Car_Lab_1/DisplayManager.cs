using System;

namespace Car_Lab_1
{
    internal sealed class DisplayManager
    {
        private static readonly DisplayManager _instance = new DisplayManager();

        public static DisplayManager Instance => _instance;

        private DisplayManager() { }

        public void ShowSection(string title)
        {
            Console.WriteLine($"=== {title.ToUpper()} ===");
        }

        public void ShowTransport(params Transport[] transports)
        {
            foreach (var transport in transports)
            {
                Console.WriteLine(transport);
            }
            Console.WriteLine();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
