using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models.Device;

namespace Web.Controllers.Mapping
{
    public interface IKeyboardMapper : IMapper
    {
        List<KeyboardAssignment> Assignments { get; set; }

        void AddAssignment(string callback, int soundId, string keyScancode, int keyModifierId, string comboScancode,
            int comboModifierId, int uiAttributeId, string description);

        void RemoveAssignment(string callback, string keyScancode);
    }
}
