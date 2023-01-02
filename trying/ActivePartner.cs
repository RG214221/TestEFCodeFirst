using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trying;

namespace TestEFCodeFirst
{
    [Table("ActivePartners")]
    public class ActivePartner : Person
    {
        public String Sex { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public int Abilities { get; set; }
        public int PersonId { get; set; }
    }
}
