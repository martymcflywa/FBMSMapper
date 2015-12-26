using System.Collections.Generic;
using Web.Models.Device;

namespace Web.Controllers.Mapper
{
    public interface IKeyboardMapper
    {
        List<KeyboardAssignment> Assignments { get; set; }

        void AddAssignment(string callback, int soundId, string keyScancode, int keyModifierId, string comboScancode,
            int comboModifierId, int uiAttributeId, string description);

        void RemoveAssignment(string callback, string keyScancode);
    }
}
