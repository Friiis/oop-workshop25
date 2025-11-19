namespace Domain
{
    class System
    {
        static bool programRunning = true;
        static void Main(string[] args)
        {
            while (programRunning)
            {
                Console.Write("> ");
                string? Cmd = Console.ReadLine();
                Console.WriteLine(Cmd);
            }
        }
    }
}