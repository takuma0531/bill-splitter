namespace BillSplitterApi.Models
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual object Payment { get; set; }
    }
}
