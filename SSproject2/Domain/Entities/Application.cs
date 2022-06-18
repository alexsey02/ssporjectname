using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Domain.Entities
{
    public class Application//объявление модели заявки
    {
        [Key]
        [Required]
        public Guid ID { get; set; }
        [Required]
        [Display(Name ="Почта заявки")]
        public string mail { get; set; }

        [Required]
        [Display(Name = "Текст заявки")]
        public  string AppText { get; set; } = "Содержание заявки";

        [Required]
        [Display(Name = "Статус заявки")]
        public string AppStatus { get; set; }

        [Required]
        [Display(Name = "Номер заявки")]
        public int AppNumber { get; set; }
    }
}
