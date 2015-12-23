using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.DataAccess.Domain.Context;
using Web.DataAccess.Repositories.Interfaces;
using Web.DataAccess.Repositories.Interfaces.Base;

namespace Web.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ResourcesContext _context;
        public ICallbackRepository Callbacks { get; set; }
        public IScancodeRepository Scancodes { get; set; }

        public UnitOfWork(ResourcesContext context)
        {
            _context = context;
            Callbacks = new CallbackRepository(_context);
            Scancodes = new ScancodeRepository(_context);
        }
        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}