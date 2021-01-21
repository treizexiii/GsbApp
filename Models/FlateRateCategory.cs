using System.ComponentModel.DataAnnotations;

namespace GsbApp.Models
{
    public class FlateRateCategory
    {
        [Key]
        public int IdFlateRateCategory { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
