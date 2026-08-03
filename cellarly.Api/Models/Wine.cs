using System.ComponentModel.DataAnnotations;

namespace cellarly.Api.Models
{
    public class Wine
    {

        public int id { get; set; }

        [Required(ErrorMessage = "O Campo nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo nome deve ter no máximo 50 caracteres")]

        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Campo país é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo país deve ter no máximo 50 caracteres")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Campo vinicula é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo vinicula deve ter no máximo 50 caracteres")]
        public string Winery { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Campo uva é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo uva deve ter no máximo 50 caracteres")]
        public string Grape { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Campo ano é obrigatório")]
        [Range(1900, 2100, ErrorMessage = "O Campo ano deve ser um número entre 1900 e 2100")]
        public int Vintage { get; set; }

        [Required(ErrorMessage = "O Campo teor alcoólico é obrigatório")]
        [Range(0, 100, ErrorMessage = "O Campo teor alcoólico deve ser um número entre 0 e 100")]
        public decimal AlcoholContent { get; set; }

        [Required(ErrorMessage = "O Campo volume é obrigatório")]
        [Range(0, 1000, ErrorMessage = "O Campo volume deve ser um número entre 0 e 1000")]
        public int VolumeMl { get; set; }

        [Required(ErrorMessage = "O Campo doçura é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo doçura deve ter no máximo 50 caracteres")]
        public string Sweetness { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Campo tipo de vinho é obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo tipo de vinho deve ter no máximo 50 caracteres")]
        public string WineType { get; set; } = string.Empty;
    }
}

