using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CSharpExercise
{
    public class AppCoreInicialization
    {
        string filePath;
        public AppCoreInicialization(string filePath)
        {
            this.filePath = filePath;
        }

        List<InputDataListRowId> inputDataListRowId = new List<InputDataListRowId>();
        List<InputDataListChildrenRow> inputDataListChildrenRow = new List<InputDataListChildrenRow>();
        public void DataInicialization()
        {
            var document = File.ReadLines(filePath);
            
            foreach (var item in document)
            {
                var values = item.Split(',');                
                var newPersonRowId = new InputDataListRowId
                {
                    RowId = int.Parse(values[0]),
                    ChildrenId = int.Parse(values[1]),
                    Name = values[2],
                    Surname = values[3],
                    Company = values[4],
                    Position = values[6],
                };
                inputDataListRowId.Add(newPersonRowId);
            }
            inputDataListRowId.Sort();
            
            foreach (var item in document)
            {
                var values = item.Split(',');
                var newPersonChildrenRow = new InputDataListChildrenRow
                {
                    RowId = int.Parse(values[0]),
                    ChildrenId = int.Parse(values[1]),
                    Name = values[2],
                    Surname = values[3],
                    Company = values[4],
                    Position = values[6],
                };
                inputDataListChildrenRow.Add(newPersonChildrenRow);
            }
            inputDataListChildrenRow.Sort();
        }

        public List<InputDataListChildrenRow> DataCalucation(List<InputDataListChildrenRow> other)
        {
            DataInicialization();

            Console.WriteLine($"{inputDataListRowId.First().Name} {inputDataListRowId.First().Surname}, {inputDataListRowId.First().Company}, {inputDataListRowId.First().Position}");
            
            if (other.ChildrenId == this.inputDataListRowId.)
            { base  

            }

           





            return "";
        }
    }
}
