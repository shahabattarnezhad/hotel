using Domain.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class ApplicationUser
{
    [Key]
    public Guid Id { get; set; }


    [Required(ErrorMessage = "The user name is required.")]
    [MaxLength(100, ErrorMessage = "Maximumn characters for user name is 100 characters.")]
    [MinLength(5, ErrorMessage = "Minimum characters for user name is 5 characters.")]
    [DisplayName("Username")]
    public string UserName { get; set; } = string.Empty;


    [Required(ErrorMessage = "The name is required.")]
    [MaxLength(100, ErrorMessage = "Maximumn characters for name is 100 characters.")]
    [MinLength(5, ErrorMessage = "Minimum characters for name is 5 characters.")]
    [DisplayName("Full Name")]
    public string Name { get; set; } = string.Empty;


    public ApplicationRole Role { get; set; }

    [Phone]
    [DataType(DataType.PhoneNumber)]
    public string Phone { get; set; } = string.Empty;

    [EmailAddress]
    public string Email { get; set; } = string.Empty;


    public bool IsActive { get; set; }
}
