using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Ajax.Utilities;
using Web.DataAccess.Domain.Context;
using Web.DataAccess.Domain.Entities;
using Web.DataAccess.Repositories.Interfaces;
using Web.Models;

namespace Web.DataAccess.Repositories
{
    public class ScancodeRepository : Repository<Scancode>, IScancodeRepository
    {
        public ScancodeRepository(DbContext context) : base(context)
        {
        }

        public ResourcesContext ResourcesContext => Context as ResourcesContext;

        public IEnumerable<Scancode> GetAllByCountry(int countryId)
        {
            switch (countryId)
            {
                case (int)Constants.Countries.US:
                    return ResourcesContext.Scancodes
                        .Include(c => c.USKey);
                case (int)Constants.Countries.German:
                    return ResourcesContext.Scancodes
                        .Include(c => c.GermanKey);
                case (int)Constants.Countries.French:
                    return ResourcesContext.Scancodes
                        .Include(c => c.FrenchKey);
                default:
                    throw new ArgumentException("Invalid countryId");
            }
        }

        public IEnumerable<Scancode> GetByCountryAndId(int countryId, int scancodeId)
        {
            switch (countryId)
            {
                case (int)Constants.Countries.US:
                    return ResourcesContext.Scancodes
                        .Include(c => c.USKey)
                        .Where(c => c.ScancodeId == scancodeId);
                case (int)Constants.Countries.German:
                    return ResourcesContext.Scancodes
                        .Include(c => c.GermanKey)
                        .Where(c => c.ScancodeId == scancodeId);
                case (int)Constants.Countries.French:
                    return ResourcesContext.Scancodes
                        .Include(c => c.FrenchKey)
                        .Where(c => c.ScancodeId == scancodeId);
                default:
                    throw new ArgumentException("Invalid countryId");
            }
        }

        public IEnumerable<Scancode> GetByCountryAndScancode(int countryId, string code)
        {
            switch (countryId)
            {
                case (int)Constants.Countries.US:
                    return ResourcesContext.Scancodes
                        .Include(c => c.USKey)
                        .Where(c => c.Code == code);
                case (int)Constants.Countries.German:
                    return ResourcesContext.Scancodes
                        .Include(c => c.GermanKey)
                        .Where(c => c.Code == code);
                case (int)Constants.Countries.French:
                    return ResourcesContext.Scancodes
                        .Include(c => c.FrenchKey)
                        .Where(c => c.Code == code);
                default:
                    throw new ArgumentException("Invalid countryId");
            }
        } 
    }
}