using Web.DataAccess.Repositories;

namespace Web.Controllers.Mapper
{
    public interface IMapper
    {
        UnitOfWork UnitOfWork { get; set; }
    }
}