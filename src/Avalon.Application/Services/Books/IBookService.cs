using Avalon.Application.DTOs.Books.v1;
using Avalon.Application.DTOs.Books.v1.Commands;

namespace Avalon.Application.Services.Books;

public interface IBookService
{
    // Получить одну книгу по ID
    Task<BookDtoV1> GetByIdAsync(Guid id, CancellationToken ct = default);
    
    // Получить все книги (с пагинацией в будущем)
    Task<IEnumerable<BookDtoV1>> GetAllAsync(CancellationToken ct = default);
    
    // Создать новую книгу
    Task<BookDtoV1> CreateAsync(CreateBookDtoV1 dto, CancellationToken ct = default);
    
    // Обновить книгу
    Task<BookDtoV1> UpdateAsync(Guid id, UpdateBookDtoV1 dto, CancellationToken ct = default);
    
    // Удалить книгу
    Task DeleteAsync(Guid id, CancellationToken ct = default);
}