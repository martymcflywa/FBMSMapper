using System.Collections.Generic;
using System.Linq;
using Web.DataAccess.Repositories;
using Web.Models.Device;

namespace Web.Controllers.Mapper
{
    public class KeyboardMapper : IKeyboardMapper
    {
        public UnitOfWork UnitOfWork { get; set; }
        public List<KeyboardAssignment> Assignments { get; set; }

        public KeyboardMapper(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public void AddAssignment(string callback, int soundId, string keyScancode, int keyModifierId, string comboScancode,
            int comboModifierId, int uiAttributeId, string description)
        {
            Assignments.Add(new KeyboardAssignment(callback, soundId, keyScancode, keyModifierId, comboScancode, comboModifierId, uiAttributeId, description));
        }

        public void RemoveAssignment(string callback, string code)
        {
            var item = Assignments
                .First(c => c.Callback == callback &&
                            c.KeyScancode == code);

            Assignments.Remove(item);
        }
    }
}