using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
//    One Class should be responsible for one task.

//E.g.
//Want to Insert data into database and want to log the details.
//If we create a class to represent DataAccess, it should not be used to save to the database(task 1), as well as log the details(task 2).
 
//Problem:
//If we want to change database type or we want to change the logger type/location, If both tasks present in single class, one task changes affects to another.

//Solution:
//Create one class for saving into database and another class for logging the details.

    // Data access class is only responsible for data base related operations 
    class DataAccess
    {
        public static void InsertData()
        {
            Console.WriteLine("Data inserted into database successfully");
        }
    }
    // Logger class is only responsible for logging related operations 
    class Logger
    {
        public static void WriteLog()
        {
            Console.WriteLine("Logged Time:" + DateTime.Now.ToLongTimeString() + " Log  Data insertion completed successfully");
        }
    }
}
