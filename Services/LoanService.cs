using MVCMiniProjects.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MVCMiniProjects.Services
{
    public class LoanService
    {
        public Loan CalculateLoan(Loan loan)
        {
            var num = (loan.LoanAmount) * (loan.InterestRate / 1200);
            var num2 = (decimal)(1 - Math.Pow((double)1 + (double)loan.InterestRate / 1200, -loan.Term));
            var payment = Math.Round(num / num2, 2);

            var interest = (payment * loan.Term) - loan.LoanAmount;
            var cost = (payment * loan.Term) + loan.LoanAmount;

            return new();
        }
    }
}
