namespace Villa_Api.Logging
{
    public class Logger : ILogger
    {
        public void log(string message, string type)
        {
            if (type == "Error")
            {
                Console.WriteLine("Error -" + message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
