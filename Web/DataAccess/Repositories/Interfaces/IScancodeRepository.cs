using System.Collections.Generic;
using Web.DataAccess.Domain.Entities;
using Web.DataAccess.Repositories.Interfaces.Base;

namespace Web.DataAccess.Repositories.Interfaces
{
    public interface IScancodeRepository : IRepository<Scancode>
    {
        IEnumerable<Scancode> GetAllByCountry(int countryId);
        IEnumerable<Scancode> GetByCountryAndId(int countryId, int scancodeId);
        IEnumerable<Scancode> GetByCountryAndScancode(int countryId, string code);
    }
}
