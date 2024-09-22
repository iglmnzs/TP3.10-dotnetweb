using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AT1._10_dotnetweb.Models
{
    public class Produto
    {
        [Key] // Define explicitamente que 'Id' é a chave primária
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do produto deve ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório")]
        [Range(0.01, 9999.99, ErrorMessage = "O preço deve estar entre 0.01 e 9999.99")]
        [Column(TypeName = "decimal(10, 2)")] // Configura a precisão do campo no banco de dados SQLite
        public decimal Preco { get; set; }
    }
}
