using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;
using Acme.Bookstore.Books;

namespace Acme.Bookstore;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class BookstoreBookToBookDtoMapper : MapperBase<Book, BookDto>
{
    public override partial BookDto Map(Book source);

    public override partial void Map(Book source, BookDto destination);
}

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class BookstoreCreateUpdateBookDtoToBookMapper : MapperBase<CreateUpdateBookDto, Book>
{
    public override partial Book Map(CreateUpdateBookDto source);

    public override partial void Map(CreateUpdateBookDto source, Book destination);
}
