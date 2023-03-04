using Domain.Models.Enums;
using Domain.Models.ValueObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public class Customer
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public Address? Address { get; set; }

    public Gender Gender { get; set; }

    public CustomerCategory Category { get; set; }


    
    public Guid CustomerDetailId { get; set; }
    public virtual CustomerDetail? CustomerDetail { get; set; }
}
