using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess.Interfaces;
using Web.Models.Domain.Entities;

namespace Web.Models.Domain.Repositories.Interfaces
{
    public interface ICallbackRepository : IRepository<Callback>
    {
        IEnumerable<Callback> GetByCategory(int id);
        IEnumerable<Callback> GetBySection(int id);
    }
}