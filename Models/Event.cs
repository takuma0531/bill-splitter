using System.Collections.Generic;

namespace BillSplitterApi.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual TotalPayment TotalPayment { get; set; }
    }
}
