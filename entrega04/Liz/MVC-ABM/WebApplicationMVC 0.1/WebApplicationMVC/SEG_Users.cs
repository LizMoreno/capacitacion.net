namespace WebApplicationMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEG_Users
    {
        public long Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string DisplayName { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, ErrorMessage = "Longitud máxima 100")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(15, ErrorMessage = "Longitud entre 6 y 15 caracteres.",
                      MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool? Active { get; set; }
    }
}
