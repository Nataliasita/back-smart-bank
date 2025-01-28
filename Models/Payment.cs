namespace PaymentsSmartBankAPI.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Description { get; set; } = string.Empty; 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public User User { get; set; }

    }

    public enum PaymentStatus
    {
        Pending,
        Success,
        Failed
    }

}