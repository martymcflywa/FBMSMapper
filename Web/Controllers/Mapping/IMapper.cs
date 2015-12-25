using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.DataAccess.Repositories;
using Web.DataAccess.Repositories.Interfaces.Base;
using Web.Models.Device;

namespace Web.Controllers.Mapping
{
    public interface IMapper
    {
        UnitOfWork UnitOfWork { get; set; }
        void RemoveAssignment(string callback, string code);
    }
}