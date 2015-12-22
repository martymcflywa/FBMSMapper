using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using Web.Models.Domain.Entities;

namespace Web.Models.Domain.Repositories.Interfaces
{
    public interface IScancodeRepository : IRepository<Scancode>
    {
        IEnumerable<Scancode> GetUSCodes();
        IEnumerable<Scancode> GetGermanCodes();
        IEnumerable<Scancode> GetFrenchCodes();
    }
}
