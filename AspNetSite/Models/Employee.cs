using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetSite.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле не может быть пустым")]
        [DisplayName(displayName:"Ф.И.О.")]
        [StringLength(250,ErrorMessage = "Длинна не может превышать 250 символов")]
        public string FullName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле не может быть пустым")]
        [DisplayName(displayName: "Должность")]
        [StringLength(1000, ErrorMessage = "Длинна не может превышать 1000 символов")]
        public string Post { get; set; }
    }
}
