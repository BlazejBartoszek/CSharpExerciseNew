using System;

namespace CSharpExercise
{
    public class InputDataListRowId : IComparable<InputDataListRowId>
    {
        public int ChildrenId { get; set; }
        public int RowId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }

        public int CompareTo(InputDataListRowId other)
        {
            return this.RowId.CompareTo(other.RowId);      
        }
    }
}
