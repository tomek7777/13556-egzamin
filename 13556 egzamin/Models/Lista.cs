using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _13556_egzamin.Models
{
    public class Lista
    {
        public int Id { get; set; }
        [Display(Name = "Numer Indeksu")]
        [Required(ErrorMessage = "Numer Indeksu is required")]
        public int NrIndeksu { get; set; }

        [Range(2, 5)]
        [Display(Name = "Ocena")]
        public int Ocena { get; set; }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Przedmiot musi zawierać między 2, a 20 znaków")]
        [Display(Name = "Przedmiot")]
        public string Przedmiot { get; set; }

    }
}
