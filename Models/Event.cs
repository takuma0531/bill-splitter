using System.Collections.Generic;

namespace BillSplitterApi.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<object> People { get; set; }
        public virtual object TotalPayment { get; set; }
    }
}
