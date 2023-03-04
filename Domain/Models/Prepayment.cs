namespace Domain.Models;

public class Prepayment : Payment
{
    public string PrepaymentTitle { get; set; } = string.Empty;

    public DateTime PrepaymentDate { get; set; }

    public decimal PrepaymentPrice { get; set; }

    public string PrepaymentDescription { get; set; } = string.Empty;
}
