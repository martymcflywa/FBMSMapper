using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Controllers.Mapping
{
    public interface IKeyboardMapper : IMapper
    {
        void AddAssignment(string callback, int? soundId, string keyScancode, int keyModifierId, string comboScancode, int? comboModifierId, int? uiAttributeId, string description);
    }
}
