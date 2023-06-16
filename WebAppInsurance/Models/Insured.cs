using System.ComponentModel.DataAnnotations;

namespace WebAppInsurance.Models
{
    public class Insured
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Chyba: špatně zadané jméno")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Jméno musí mít 3 až 15 písmen.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Chyba: špatně zadané příjmení")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Příjmení musí mít 3 až 15 písmen.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Chyba: špatně zadaný email")]
        [StringLength(100, ErrorMessage = "Email může mít maximálně 100 znaků.")]
        [EmailAddress(ErrorMessage = "Neplatný formát emailu.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Chyba: špatně zadané telefonní číslo")]
        [StringLength(20, ErrorMessage = "Telefonní číslo může mít maximálně 20 znaků.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Chyba: špatně zadaná ulice")]
        [StringLength(50, ErrorMessage = "Ulice může mít maximálně 50 znaků.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Chyba: špatně zadané číslo popisné")]
        [StringLength(10, ErrorMessage = "Číslo popisné může mít maximálně 10 znaků.")]
        public string HouseNumber { get; set; }

        [Required(ErrorMessage = "Chyba: špatně zadané město")]
        [StringLength(50, ErrorMessage = "Město může mít maximálně 50 znaků.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Chyba: špatně zadané PSČ")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "PSČ musí mít 5 znaků.")]
        public string ZIPCode { get; set; }

        public virtual ICollection<Insurance>? MyInsurances { get; set; }

    }
}
