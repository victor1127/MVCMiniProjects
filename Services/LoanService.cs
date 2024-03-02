using MVCMiniProjects.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVCMiniProjects.Services
{
    public class LoanService
    {
        public static Loan CalculateLoan(Loan loan)
        {
            var num = (loan.LoanAmount) * (loan.InterestRate / 1200);
            var num2 = (decimal)(1 - Math.Pow((double)1 + (double)loan.InterestRate / 1200, -loan.Term));
            var payment = num / num2;

            loan.TotalInterest = Math.Round((payment * loan.Term) - loan.LoanAmount, 2);
            loan.TotalCost = Math.Round((payment * loan.Term) + loan.LoanAmount, 2);
            loan.TotalPrincipal = loan.LoanAmount;

            return CalculatePayments(loan, payment);
        }

        private static Loan CalculatePayments(Loan loan, decimal payment)
        {
            int month = 1;
            var remainingBalance = loan.LoanAmount;
            var interestPayment = remainingBalance * loan.InterestRate / 1200;
            var totalInterest = interestPayment;
            var principal = payment - interestPayment;

            while (month <= loan.Term)
            {
                loan.PaymentDetails.Add(
                 new LoanPayment
                 {
                     Month = month,
                     Interest = Math.Round(interestPayment, 2),
                     TotalInterest = Math.Round(totalInterest, 2),
                     Payment = Math.Round(payment, 2),
                     Principal = Math.Round(principal, 2),
                     Balance = Math.Round(remainingBalance, 2)
                 });

                interestPayment = remainingBalance * (loan.InterestRate / 1200);
                totalInterest += interestPayment;
                principal = payment - interestPayment;
                remainingBalance -= principal;
                month++;
            }

            return loan;
        }
    }
}
