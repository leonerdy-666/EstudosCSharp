using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MeuSiteMVC.Models
{
    [Index(nameof(CodigoBarras), IsUnique = true)]
    public class ProdutoModel
    {
        public Int64 Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        public string Descricao { get; set; } = string.Empty;

        [StringLength(12, MinimumLength = 12, ErrorMessage = "O campo Código de Barras deve ter exatamente 12 caracteres.")]
        [Required]
        public string CodigoBarras { get; set; } = string.Empty;

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DataValidade { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; }

        [Range(1, 1000)]
        public int Quantidade { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public Decimal? Valor { get; set; }

        [MaybeNull]
        public string NomeFoto { get; set; }

        [MaybeNull]
        public byte[] Foto { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}