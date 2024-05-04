using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes
{
    public class Note
    {
        public int  Id {  get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public string? Category { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}
