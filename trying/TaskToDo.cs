using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCodeFirst
{
    
    public class TaskToDo
    {
        public int Id { get; set; }
        public DateOnly DateToDo { get; set; }
        public String Description { get; set; }
        public override string ToString()
        {
            return Id + " " + DateToDo + " " + Description;
        }
    }
}
