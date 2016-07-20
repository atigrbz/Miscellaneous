using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    //Classes, modules, functions, etc.should be open for extension, but closed for modification.

    //Create a Base class with Required functionality, and ensure we will not modify that class. (Closed for modification)
    //Create a Derived class by inheriting the Base class for extension(Open for modification)


    class OpenClosePrincipleDemo
    {
        public static void OSPDemo()
        {
            Console.WriteLine("\n\nOpen Close Principle Demo ");

            DataProvider DataProviderObject = new SqlDataProvider();
            DataProviderObject.OpenConnection();
            DataProviderObject.ExecuteCommand();
            DataProviderObject.CloseConnection();

            DataProviderObject = new OracleDataProvider();
            DataProviderObject.OpenConnection();
            DataProviderObject.ExecuteCommand();
            DataProviderObject.CloseConnection();
        }
    }



    public abstract class DataProvider
    {
        public abstract int OpenConnection();
        public abstract int CloseConnection();
        public abstract int ExecuteCommand();
    }

    public class SqlDataProvider : DataProvider
    {
        public override int CloseConnection()
        {
            Console.WriteLine("\nSql Connection opened successfully");
            return 1;
        }

        public override int ExecuteCommand()
        {
            Console.WriteLine("Sql Connection closed successfully");
            return 1;
        }

        public override int OpenConnection()
        {
            Console.WriteLine("Sql Command Executed successfully");
            return 1;
        }
    }

    class OracleDataProvider : DataProvider
    {
        public override int OpenConnection()
        {
            Console.WriteLine("Oracle Connection opened successfully");
            return 1;
        }
        public override int CloseConnection()
        {
            Console.WriteLine("Oracle Connection closed successfully");
            return 1;
        }
        public override int ExecuteCommand()
        {
            Console.WriteLine("Oracle Command Executed successfully");
            return 1;
        }
    }


}
