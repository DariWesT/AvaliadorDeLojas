using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCrud_.Models
{
    [Table("Operadoras")]

    public class Operadoras
    {     
   
            [Display(Name = "Código")]
            [Column("Id")]
            public int Id { get; set; }

            [Display(Name = "Loja")]
            [Column("Operadora")]
            public string Operadora { get; set; }     

    }

}
