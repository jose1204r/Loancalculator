using MorgageCalculator.Models;

namespace MorgageCalculator.Methods
{
    public class Loanmethods
    {


       public Loan GetPayments(Loan loan )
        {


            loan.payment = calcPayment(loan.amount,loan.rate,loan.term);

            var balance = loan.amount;
            var totalinterest = 0.0m;
            var monthlyinteres = 0.0m;
            var monthlyprincipal = 0.0m;
          
            var monthlyrate= calmonthlyrate(loan.rate);


            for (int month = 1; month <= loan.term ; month++)
            {

                monthlyinteres = calmonthlyrate(balance, monthlyrate);

                totalinterest += monthlyinteres;

                monthlyprincipal = loan.payment - monthlyinteres;

                balance -= monthlyprincipal;

                Loanpayment loanpayment = new();

                loanpayment.month = month;
                 
                loanpayment.payment = loan.payment;
                loanpayment.principal = monthlyprincipal;
                
                loanpayment.monthlyinteres= monthlyinteres;
                loanpayment.totalinteres= totalinterest;
                loanpayment.mybalance = balance;
                

                loan.payments.Add(loanpayment);
            }

            loan.totalinteres = totalinterest;
            loan.totalcost = loan.amount + totalinterest;

            return loan;

        }


        private decimal calcPayment(decimal amount, decimal rate, int term)
        {

           
            rate = calmonthlyrate(rate);
            var rated = Convert.ToDouble(rate);
            var amountd = Convert.ToDouble(amount);

            var paymentd = (amountd * rated)/ ( 1- Math.Pow( 1 + rated, -term) );

            return Convert.ToDecimal(paymentd);


        }

        private decimal calmonthlyrate(decimal rate) 
        {


            return rate / 1200;
        
        }

        public decimal calmonthlyrate(decimal balance, decimal monthlyrate) 
        {

            return balance * monthlyrate;
        
        }

    }
}
