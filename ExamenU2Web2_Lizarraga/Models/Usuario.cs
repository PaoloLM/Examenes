namespace ExamenU2Web2_Lizarraga.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int usuario_id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        [Required]
        [StringLength(150)]
        public string apellido { get; set; }

        [Column("usuario")]
        [Required]
        [StringLength(50)]
        public string usuario1 { get; set; }

        [Required]
        [StringLength(150)]
        public string clave { get; set; }

        [Required]
        [StringLength(30)]
        public string rol { get; set; }

        [StringLength(10)]
        public string estado { get; set; }
    }
}
