namespace BillSplitterApi.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int PaymentAmount { get; set; }
        public virtual Person Person { get; set; }
    }
}
