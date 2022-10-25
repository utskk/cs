using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new FileLogger();
            customerManager.Add();
            
            customerManager.Delete();

           
        }
    }
   class CustomerManager
    {
        public ILogger logger { get; set; }
        public void Add()
        {
            logger.Log();
            Console.WriteLine("Customer added !");
        }
        public void Delete()
        {
            logger.Delete();
            Console.WriteLine("Customer Deleted.!");
        }

    }
    interface ILogger
    {
        void Log();
        void Delete();
    }
   class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file.!");
        }
        public void Delete()
        {
            Console.WriteLine("..!");
        }

    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database.!");
        }
        public void Delete()
        {
            Console.WriteLine("..!");
        }

    }

}
