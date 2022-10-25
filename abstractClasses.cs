using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            Database database1 = new SqlServer();
            database.Add();
            database1.Add();
            
            database.Delete();
            database1.Delete();


        }
          abstract class Database {
        public void Add()
            {
                Console.WriteLine("Database added.");
            }
            abstract public void Delete();
        }
        class Oracle : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Oracle.");
            }
        }
        class SqlServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Sql.");
            }
        }
    }
}
