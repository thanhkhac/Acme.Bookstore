using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;
using Acme.Bookstore.Books;

namespace Acme.Bookstore.Web;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class BookstoreWebMappers : MapperBase<BookDto, CreateUpdateBookDto>
{
    public override partial CreateUpdateBookDto Map(BookDto source);

    public override partial void Map(BookDto source, CreateUpdateBookDto destination);
}
