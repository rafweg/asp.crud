using System.ComponentModel.DataAnnotations;

namespace Filmy.Models;

public class Dane
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Podaj imie")]
    public string Imie { get; set; }
    
    [Required(ErrorMessage = "Podaj email")]
    [RegularExpression("#%&/>")]
    public string Email { get; set; }
    
    public string Temat { get; set; }
    
    public string Tresc { get; set; }
}