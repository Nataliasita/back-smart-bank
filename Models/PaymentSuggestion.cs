namespace PaymentsSmartBankAPI.Models
{
    public class PaymentSuggestion
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime SuggestedDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; 
        public User User { get; set; }
    }


}