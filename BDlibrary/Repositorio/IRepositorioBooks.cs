using BDlibrary.Modelos;

namespace BDlibrary.Repositorio
{
    public interface IRepositorioBooks
    {
        Task<List<Book>> GetAll();
        Task<Book> Get(int id);
        Task<Book> Add(Book book);
        Task Update(int id, Book book);
        Task Delete(int id);
    }
}
