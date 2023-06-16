using System.ComponentModel.DataAnnotations;

namespace WebAppInsurance.Models
{
    public class Insurance
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Chyba: Prosím vyberte z možností")]
        public string InsuranceName { get; set; }

        [Required(ErrorMessage = "Chyba: Prosím vyberte z možností")]
        public string InsuranceSubject { get; set; }

        [Range(100, 1000000, ErrorMessage = "Chyba: Částka musí být mezi 100 a 1 000 000")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Chyba: Špatně zadaný čas začátku pojištění")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Chyba: Špatně zadaný čas konce pojištění")]
        public DateTime EndDate { get; set; }

        public int? InsuredId { get; set; }

        public Insured? Insured { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EndDate < StartDate)
            {
                yield return new ValidationResult("Chyba: Datum konce musí být po datu začátku", new[] { nameof(EndDate) });
            }
        }
    }
}
