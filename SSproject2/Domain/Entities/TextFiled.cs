using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Domain.Entities
{
    public class TextFiled : EntityBase//объявление модели страницы
    {
        [Required]
        public string CodeWord { get; set; }
        [Required]
        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; } = "Информационная страница";
        
        [Display(Name = "Содержание страницы")]
        public override string Text { get; set; } = "Содержание заполняется администратором";
    }
}
