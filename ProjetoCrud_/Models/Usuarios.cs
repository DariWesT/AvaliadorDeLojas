using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCrud_.Models
{
    [Table("Usuario")]
    public class Usuarios
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "Rua")]
        [Column("Rua")]
        public string Rua { get; set; }

        [Display(Name = "Número")]
        [Column("Numero")]
        public int Numero { get; set; }

        [Display(Name = "Complemento")]
        [Column("Complemento")]
        public string Complemento { get; set; }

        [Display(Name = "Localidade")]
        [Column("Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "CódigoPostal")]
        [Column("Cep")]
        public int Cep { get; set; }

        [Display(Name = "Cidade")]
        [Column("Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Distrito")]
        [Column("Estado")]
        public string Estado { get; set; }
    }
}
