using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

/*
Una interfaz es un contrato que solo tiene la firma de los metodos que la clase que hereda
esta obligada a implementar, estos metodos son obligatorios
*/
public interface IArtistService
{
  Task<IEnumerable<Artist>> GetArtistsAsync();
  Task<Artist> GetById(int id);
  Task<Artist> CreateArtists(Artist artist);
  Task<Artist> UpdateArtists(Artist artist);
}