using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.DataAccess.Repositories.Interfaces.Base
{
    public interface IUnitOfWork : IDisposable
    {
        ICallbackRepository Callbacks { get; set; }
        IScancodeRepository Scancodes { get; set; }
        int Complete();
    }
}
