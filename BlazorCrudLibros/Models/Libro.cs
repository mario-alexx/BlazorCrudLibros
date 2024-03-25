using System.ComponentModel.DataAnnotations;

namespace BlazorCrudLibros.Models
{
	public class Libro
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "El Título es obligatorio")]
		public string Titulo { get; set; }
		[Required(ErrorMessage = "La Descripción es obligatoria")]
		public string Descripcion { get; set; }
		[Required(ErrorMessage = "El Autor es obligatorio")]
		public string Autor { get; set; }
		[Required(ErrorMessage = "La cantidad de páginas es obligatorio")]
		public int Paginas { get; set; }
		[Required(ErrorMessage = "El Precio es obligatorio")]
		public int Precio { get; set; }
		public DateTime FechaCreacion { get; set; }
	}
}
