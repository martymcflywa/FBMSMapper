using System.Collections.Generic;
using Web.DataAccess.Domain.Entities;
using Web.DataAccess.Repositories.Interfaces.Base;

namespace Web.DataAccess.Repositories.Interfaces
{
    public interface ICallbackRepository : IRepository<Callback>
    {
        IEnumerable<Callback> GetByCategory(int id);
        IEnumerable<Callback> GetBySection(int id);
    }
}