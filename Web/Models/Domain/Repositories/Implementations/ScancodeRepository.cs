using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web.Models.Domain.Context;
using Web.Models.Domain.Entities;
using Web.Models.Domain.Repositories.Interfaces;

namespace Web.Models.Domain.Repositories.Implementations
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