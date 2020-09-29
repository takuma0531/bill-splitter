namespace BillSplitterApi.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public virtual Event Event { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
