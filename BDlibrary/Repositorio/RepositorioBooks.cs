using BDlibrary.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BDlibrary.Repositorio
{
    public class RepositorioBooks : IRepositorioBooks
    {
        private readonly LibraryDBContext _context;
        public RepositorioBooks(LibraryDBContext context)
        {
            _context = context;
        }
        public async Task<Book> Add(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return book;
        }
        public async Task Delete(int id)
        {
            var persona = await _context.Books.FindAsync(id);
            if (persona != null)
            {
                _context.Books.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Book?> Get(int id)
        {
            return await _context.Books.FindAsync(id);
        }
        public async Task<List<Book>> GetAll()
        {
            return await _context.Books.ToListAsync();
        }
        public async Task<List<Author>> GetAuthors()
        {
            return await _context.Authors.ToListAsync();
        }
        public async Task Update(int id, Book book)
        {
            var bookactual = await _context.Books.FindAsync(id);
            if (bookactual != null)
            {
                bookactual.Name = book.Name;
                bookactual.Description = book.Description;
                bookactual.YearPublished = book.YearPublished;
                bookactual.AuthorId = book.AuthorId;
                await _context.SaveChangesAsync();
            }
        }
    }
}
