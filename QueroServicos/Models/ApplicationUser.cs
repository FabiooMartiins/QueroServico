using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueroServicos.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Type { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey(nameof(Address))]
        [Required]
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
    }
}