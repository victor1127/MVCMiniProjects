using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace MVCMiniProjects.Models
{
    public class Loan
    {
        public decimal LoanAmount { get; set; }    
        public int Term  { get; set;}
        public decimal InterestRate { get; set; }

        [Display(Name = "Total Principal")]
        public decimal TotalPrincipal { get; set; }

        [Display(Name = "Total Interest")]
        public decimal TotalInterest { get; set; }

        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }

        public List<LoanPayment> PaymentDetails { get; set; } = new();
    }

    public class LoanPayment
    {
        public int Month { get; set; } 
        public decimal Payment { get; set; }
        public decimal Principal { get; set; }
        public decimal Interest { get; set; }
        public decimal TotalInterest { get; set; }
        public decimal Balance { get; set; }
    }
}
