using System.ComponentModel.DataAnnotations;

namespace CinemaAPI.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O genêro do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do genêro não pode exceder 50 caractéres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 a 600 minutos")]
    public int Duracao { get; set; }
}
