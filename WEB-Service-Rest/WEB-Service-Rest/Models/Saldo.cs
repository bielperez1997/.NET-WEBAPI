using System.ComponentModel.DataAnnotations;

namespace WEB_Service_Rest.Models
{
    public class Saldo
    {
        [Key]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Não é possível acessar o saldo de sua conta")]
        public int IdSaldo { get; set; }

        [Required(ErrorMessage = "Não é possível acessar o saldo de sua conta")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Não é possível acessar o saldo de sua conta")]
        public string SaldoConta { get; set; }

    }
}
