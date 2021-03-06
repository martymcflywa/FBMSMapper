﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Web.DataAccess.Domain.Context;
using Web.DataAccess.Domain.Entities;
using Web.DataAccess.Repositories.Interfaces;

namespace Web.DataAccess.Repositories
{
    public class CallbackRepository : Repository<Callback>, ICallbackRepository
    {
        public CallbackRepository(ResourcesContext context) : base(context)
        {
        }

        public ResourcesContext ResourcesContext => Context as ResourcesContext;

        public IEnumerable<Callback> GetById(int id)
        {
            return ResourcesContext.Callbacks
                .Include(c => c.Category)
                .Include(c => c.Section)
                .Where(c => c.CallbackId == id);
        }

        public IEnumerable<Callback> GetByCommand(string command)
        {
            return ResourcesContext.Callbacks
                .Include(c => c.Category)
                .Include(c => c.Section)
                .Where(c => c.Command == command);
        }

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

        public IEnumerable<Callback> GetByCategoryAndSection(int categoryId, int sectionId)
        {
            return ResourcesContext.Callbacks
                .Include(c => c.Category)
                .Include(c => c.Section)
                .Where(c => c.CategoryId == categoryId &&
                            c.SectionId == sectionId);
        }
    }
}