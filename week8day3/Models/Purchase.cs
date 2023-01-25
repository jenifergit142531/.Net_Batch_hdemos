using System.ComponentModel.DataAnnotations;

namespace week8day3.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseId { get; set; }

        [Required(ErrorMessage ="Product name is required for billing")]
        public string ProductName { get; set; }

        [Range(1,5,ErrorMessage ="You can purchase only 1 -5 items for the single product")]
        public int NumberOfItems { get; set; }

        [StringLength(20,ErrorMessage ="Address should be less than 30 characters")]
        public string Address { get; set; }

        [EmailAddress(ErrorMessage ="Email id is not valid")]
        public string Email { get; set; }

        [Phone(ErrorMessage ="Phone number invalid")]
        public string PhoneNumber { get; set; }

    }
}
