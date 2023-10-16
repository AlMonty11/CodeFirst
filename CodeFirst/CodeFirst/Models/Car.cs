using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo obligatorio")]
        [MaxLength(15,ErrorMessage ="El campo no puede tener más de 15 caracteres")]
        [MinLength(3, ErrorMessage = "El campo no puede tener menos de 3 caracteres")]
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(1,100,ErrorMessage ="La edad debe estar comprendida entre 1 y 100")]
        [DisplayName("Edad")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(0,10,ErrorMessage ="La nota debe estar comprendida entre 0 y 10")]
        [DisplayName("Nota")]
        public decimal Note { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [DataType(DataType.Date)]
        [DisplayName("Fecha")]
        public DateTime ExamDate { get; set; }

        
    }
}
