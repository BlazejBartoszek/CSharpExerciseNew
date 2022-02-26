using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise
{   
        public class InputDataListChildrenRow : IComparable<InputDataListChildrenRow>
    {
            public int ChildrenId { get; set; }
            public int RowId { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Company { get; set; }
            public string Position { get; set; }

        public int CompareTo(InputDataListChildrenRow other)
        {
            return this.ChildrenId.CompareTo(other.ChildrenId);
        }        
    }    
}
