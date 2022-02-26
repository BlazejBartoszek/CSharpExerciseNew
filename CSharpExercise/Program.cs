using System;

namespace CSharpExercise
{
    class Program
    {    
        static void Main(string[] args)
        {
            AppCoreInicialization companies_data = new AppCoreInicialization(@"C:\Users\Dell\Desktop\CExercise\C#Exercise\CSharpExercise\companies_data.csv"); // Please input here the file path
            companies_data.DataCalucation();
            Console.ReadKey();             
            
        }        
    }
}