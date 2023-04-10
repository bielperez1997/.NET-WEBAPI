using System.ComponentModel.DataAnnotations;

namespace WEB_Service_Rest.Models
{
    public class Cliente
    {
        [Key]
        [StringLength(2,MinimumLength = 1,ErrorMessage ="O Campo Id deve ter pelo menos 1 caracteres")] 
        public string ClienteID { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo Nome deve ter entre 3 e 200 caracteres")]
        public string ClienteName { get; set; }
    }
}
