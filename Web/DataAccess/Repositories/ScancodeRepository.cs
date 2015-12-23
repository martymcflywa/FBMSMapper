using System.Collections.Generic;
using System.Data.Entity;
using Web.DataAccess.Domain.Context;
using Web.DataAccess.Domain.Entities;
using Web.DataAccess.Repositories.Interfaces;

namespace Web.DataAccess.Repositories
{
    public class ScancodeRepository : Repository<Scancode>, IScancodeRepository
    {
        public ScancodeRepository(DbContext context) : base(context)
        {
        }

        public ResourcesContext ResourcesContext => Context as ResourcesContext;

        public IEnumerable<Scancode> GetUSCodes()
        {
            return ResourcesContext.Scancodes
                .Include(c => c.USKey);
        }

        public IEnumerable<Scancode> GetGermanCodes()
        {
            return ResourcesContext.Scancodes
                .Include(c => c.GermanKey);
        }

        public IEnumerable<Scancode> GetFrenchCodes()
        {
            return ResourcesContext.Scancodes
                .Include(c => c.FrenchKey);
        }
    }
}