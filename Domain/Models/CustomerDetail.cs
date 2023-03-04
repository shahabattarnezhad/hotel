namespace Domain.Models;

public class CustomerDetail
{
    public Guid Id { get; set; }

    public int SocialNumber { get; set; }

    public int InsuranceNumber { get; set; }


    public virtual Customer? Customer { get; set; }
}
