using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trying;

namespace TestEFCodeFirst
{
   [Table("HouseholdManager")]
    public class HouseholdManager : Person
    {
        public int numOfPeople { get; set; }
        public int numOfrooms { get; set; }
        public double apartmentArea { get; set; }

    }
}
