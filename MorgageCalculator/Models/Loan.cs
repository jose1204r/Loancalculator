namespace MorgageCalculator.Models
{
    public class Loan
    {

       
        public decimal amount { get; set; }

        public decimal rate { get; set; }

        public int term { get; set; }

        public decimal payment { get; set; }

        public decimal totalinteres { get; set; }

        public decimal totalcost { get; set; }

        public List<Loanpayment> payments { get; set;} = new List<Loanpayment>();





    }
}
