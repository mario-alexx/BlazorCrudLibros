using BlazorCrudLibros.Data;
using BlazorCrudLibros.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudLibros.Repositorio
{
	public class Repositorio : IRepositorio
	{
		private readonly ApplicationDbContext _contexto;

		public Repositorio(ApplicationDbContext contexto)
		{
			_contexto = contexto;
		}

		public async Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro)
		{
			var resultado = await _contexto.Libro.FindAsync(libroId);
			
			resultado.Titulo = actualizarLibro.Titulo;
			resultado.Autor = actualizarLibro.Autor;
			resultado.Descripcion = actualizarLibro.Descripcion;
			resultado.Paginas = actualizarLibro.Paginas;
			resultado.Precio = actualizarLibro.Precio;
		
			await _contexto.SaveChangesAsync();
			return resultado;
		}

		public async Task<Libro> CrearLibro(Libro crearLibro)
		{
			if(crearLibro != null)
			{
				crearLibro.FechaCreacion = DateTime.Now;
				await _contexto.Libro.AddAsync(crearLibro);
				await _contexto.SaveChangesAsync();
				return crearLibro;
			}
			else
			{
				return new Libro();
			}
		}

		public async Task EliminarLibro(int libroId)
		{
			var resultado = await _contexto.Libro.FindAsync(libroId);
			_contexto.Libro.Remove(resultado);
			await _contexto.SaveChangesAsync();	
		}

		public async Task<Libro> GetLibroId(int libroId)
		{
			var resultado = await _contexto.Libro.FindAsync(libroId);
			if(resultado != null)
			{
				return resultado;
			}
			return new Libro();
		}

		public async Task<List<Libro>> GetLibros()
		{
			return await _contexto.Libro.ToListAsync();
		}
	}
}
