using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Domain.Entities
{
    public class PostItem : EntityBase//объявление модели поста
    {
        [Required(ErrorMessage = "Заполните название поста")]
        [Display(Name ="Название поста")]
        public override string Title { get; set; }

        [Display(Name = "краткое описание поста")]
        public override string Subtitle { get; set; }

        [Display(Name = "Полное описание поста ")]
        public override string Text { get; set; }
    }
}
