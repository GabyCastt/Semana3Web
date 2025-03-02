using System.ComponentModel.DataAnnotations;

namespace NuevoIntento.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "El valor del campo debe estar entre 10 y 13 caracteres")]
        [Display(Name = "Cédula o RUC")]
        public string Cedula_RUC { get; set; }


        [Required(ErrorMessage = "El Nombre es requerido")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El Apellido es requerido")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }


        [Required(ErrorMessage = "La dirección es requerida")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }


        [Required(ErrorMessage = "El Teléfono es requerido")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El Teléfono debe tener exactamente 10 caracteres")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }


        [Required(ErrorMessage = "El campo Edad es requerido")]
        [Range(1, 99, ErrorMessage = "El valor del campo debe estar entre 1 y 99")]
        [Display(Name = "Edad")]
        public int? Edad { get; set; }


        public bool Genero { get; set; } = false;

        [Required(ErrorMessage = "La Fecha de Nacimiento es requerida")]
        [Display(Name = "Fecha de Nacimiento")]
        public DateOnly? Fecha_Nacimiento { get; set; }
    }
}
