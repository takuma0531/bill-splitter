namespace BillSplitterApi.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual object Payment { get; set; }
    }
}
