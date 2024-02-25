using System.Reflection.Metadata.Ecma335;

namespace MVCMiniProjects.Models
{
    public class Loan
    {
        public decimal LoanAmount { get; set; }    
        public int Term  { get; set;}
        public decimal InterestRate { get; set; }
        public decimal TotalPrincipal { get; set; }
        public decimal TotalInterest { get; set; }
        public decimal TotalCost { get; set; }
        public decimal Payment { get; set; }
        public decimal Principal { get; set; }
        public decimal Interest { get; set; }
        public decimal Balance { get; set; }

    }
}
