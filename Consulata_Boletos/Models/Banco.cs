using System.ComponentModel.DataAnnotations;

namespace Consulata_Boletos.Models;

public class Banco
{
    [Key]
    [StringLength(4, MinimumLength = 4, ErrorMessage = "4 digitos!")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Obrigatorio")]
    [StringLength(200, MinimumLength = 1)]
    public required string Nome_do_banco { get; set; }

    [Required(ErrorMessage = "Obrigatori")]
    public required string Codigo_do_banco { get; set; }

    [Required(ErrorMessage = "Obrigatorio")]
    [Range(0, 100, ErrorMessage = "Percentual de Juros ddeve estar entre 0 e 100 porcento")]
    public required decimal Percentual_de_Juros { get; set; }

    // Relacionamento com Boleto
    public ICollection<Boleto> Boletos { get; set; }
}
