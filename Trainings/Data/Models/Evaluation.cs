using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Evaluation : BaseModel
    {
        public Profile Profile { get; set; }
        public string Criteria { get; set; }
        public int Grade { get; set; }
    }
}
