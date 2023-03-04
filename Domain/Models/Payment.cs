namespace Domain.Models;

public class Payment
{
    public Guid Id { get; set; }

    public string PaymentTitle { get; set; } = string.Empty;

    public Guid CustomerId { get; set; }

    public int NightCount { get; set; }

    public decimal PricePerNight { get; set; }

    public decimal TotalNightPrice { get; set; }

    public decimal Tax { get; set; }

    public decimal Total { get; set; }

    public DateTime PaymentDate { get; set; }
}
