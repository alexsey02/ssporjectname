using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSproject2.Domain.Entities
{
    public class EntityBase//объявление базовой модели
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid ID { get; set; }

        [Display(Name ="Название(пост)")]
        public virtual string Title { get; set; }

        [Display(Name = "Краткое описание(пост)")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Полное  описание(пост)")]
        public virtual string Text { get; set; }

        [Display(Name = "Картинка к посту")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO метатег Title")]
        public  string MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public  string MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
