using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarjisho
{
    public class User
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public bool IsMale { get; set; }
        public bool IsFemale { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{ID}: {FirstName} {LastName}";
        }
    }
}
