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
    public class CallbackRepository : Repository<Callback>, ICallbackRepository
    {
        public CallbackRepository(ResourcesContext context) : base(context)
        {
        }

        public ResourcesContext ResourcesContext => Context as ResourcesContext;

        public IEnumerable<Callback> GetByCategory(int id)
        {
            return ResourcesContext.Callbacks
                .Include(c => c.Category)
                .Include(c => c.Section)
                .Where(c => c.CategoryId == id);
        }

        public IEnumerable<Callback> GetBySection(int id)
        {
            return ResourcesContext.Callbacks
                .Include(c => c.Category)
                .Include(c => c.Section)
                .Where(c => c.SectionId == id);
        }
    }
}