using System.ComponentModel.DataAnnotations;

namespace Consulata_Boletos.Models;

public class Boleto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    [StringLength(200, MinimumLength = 1)]
    public required string Nome_do_pagador { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    [StringLength(14, MinimumLength = 11, ErrorMessage = "invalido.")]
    public required string CpfCnpj_do_pagador { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    [StringLength(200, MinimumLength = 1)]
    public required string Nome_do_beneficiario { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    [StringLength(14, MinimumLength = 11, ErrorMessage = "invalido.")]
    public required string CpfCnpj_do_beneficiario { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero.")]
    public required decimal Valor { get; set; }

    [Required(ErrorMessage = "Obrigatório")]
    public required DateTime Data_de_vencimento { get; set; }

    public string Observacao { get; set; }

    // Relacionamento com Banco
    [Required(ErrorMessage = "Obrigatório")]
    public required int BancoId { get; set; }
    public required Banco Banco { get; set; }
}
