using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.DataAccess.Repositories;
using Web.DataAccess.Repositories.Interfaces.Base;

namespace Web.Controllers.Mapping
{
    public interface IMapper
    {
        UnitOfWork UnitOfWork { get; set; }
        List<string> AssignmentList { get; set; }
        List<string> GetAssignments();
        void RemoveAssignment();
    }
}