using BDlibrary.Modelos;

namespace BDlibrary.Repositorio
{
    public interface IRepositorioAuthors
    {
        Task<List<Author>> GetAll();
        Task<Author> Add(Author author);
        Task<Author?> GetById(int id);
        Task Update(int id, Author autor);
        Task Delete(int id);
    }
}
