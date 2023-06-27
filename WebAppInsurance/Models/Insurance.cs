using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAppInsurance.Models
{
    public class Insurance
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Prosím vyberte název pojištění")]
        public string InsuranceName { get; set; }

        [Required(ErrorMessage = "Prosím vyberte předmět pojištění")]
        public string InsuranceSubject { get; set; }

        [Range(100, 1000000, ErrorMessage = "Částka musí být mezi 100 a 1 000 000")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Prosím zadejte začátek pojištění")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Prosím zadejte konec pojištění")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public int? InsuredId { get; set; }

        public Insured? Insured { get; set; }
        public virtual ICollection<Insurance>? MyInsureds { get; set; }
        

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EndDate.Date < StartDate.Date)
            {
                yield return new ValidationResult("Datum konce musí být po datu začátku", new[] { nameof(EndDate) });
            }
        }
    }
}
