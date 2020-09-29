namespace BillSplitterApi.Models
{
    public class TotalPayment
    {
        public int Id { get; set; }
        public int Total { get; set; }
        public virtual Event Event { get; set; }
    }
}
