using System.ComponentModel.DataAnnotations;

namespace WEB_Service_Rest.Models
{
    public class Conta
    {
        [Key]
        [StringLength(2, MinimumLength = 1, ErrorMessage = "O Campo Conta deve ter pelo menos 1 caracteres")]
        public int IdConta { get; set; }


        [Required(ErrorMessage = "O campo tipo de conta é obrigatório")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo tipo de conta é obrigatório")]
        public string TipoConta { get; set;}
        
    }
}
