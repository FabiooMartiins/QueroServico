using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Identity;
using QueroServicos.Models;

namespace QueroServicos.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [ForeignKey("Subcategory")]
        public int SubcategoryId { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public string Description { get; set; }

        [ForeignKey("Contact")]
        public int ContactId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Country Country { get; set; }
        public virtual Contact Contact { get; set; }
    }
}