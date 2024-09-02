using System.ComponentModel.DataAnnotations;

namespace IOrange.ViewModels
{
    
        public class LoginViewModel
        {
            [Required]
            [Display(Name = "Name")]
            public string Name { get; set; }

            [Required]
            [Display(Name = "Id")]
            public int Id { get; set; }
        }

    
}
