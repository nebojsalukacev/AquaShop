using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderLines { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Address line")]
        [Required(ErrorMessage = "Please enter your address")]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address line 2")]
        public string AddressLine2 { get; set; }

        [Display(Name = "Zip Code")]
        [Required]
        [StringLength(15, MinimumLength = 4)]
        public string ZipCode { get; set; }

        [StringLength(20)]
        [Required]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your country")]
        [StringLength(20)]
        public string Country { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter your phone number")]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            , ErrorMessage = "The email address is not entered in a correct format")]
        [StringLength(50)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }

    }
}
