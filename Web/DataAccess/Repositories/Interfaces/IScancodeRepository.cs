using System.Collections.Generic;
using Web.DataAccess.Domain.Entities;
using Web.DataAccess.Repositories.Interfaces.Base;

namespace Web.DataAccess.Repositories.Interfaces
{
    public interface IScancodeRepository : IRepository<Scancode>
    {
        IEnumerable<Scancode> GetUSCodes();
        IEnumerable<Scancode> GetGermanCodes();
        IEnumerable<Scancode> GetFrenchCodes();
    }
}
