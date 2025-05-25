using BDlibrary.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BDlibrary.Repositorio
{
    public class RepositorioAuthors : IRepositorioAuthors
    {
        private readonly LibraryDBContext _context;
        public RepositorioAuthors(LibraryDBContext context)
        {
            _context = context;
        }
        public async Task<Author> Add(Author author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return author;
        }
        public async Task Delete(int id)
        {
            var author = await _context.Authors.FindAsync(id);
            if (author is not null)
            {
                _context.Authors.Remove(author);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<Author?> GetById(int id)
        {
            return await _context.Authors.FindAsync(id);
        }
        public async Task<List<Author>> GetAll()
        {
            return await _context.Authors.ToListAsync();
        }
        public async Task Update(int id, Author author)
        {
            var autoractual = await _context.Authors.FindAsync(id);
            if (autoractual is not null)
            {
                autoractual.Name = author.Name;
                autoractual.BirthDate = author.BirthDate;
                autoractual.Nacionalidad = author.Nacionalidad;
                await _context.SaveChangesAsync();
            }
        }
    }
}
