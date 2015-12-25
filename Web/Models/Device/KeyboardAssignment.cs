using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace Web.Models.Device
{
    public class KeyboardAssignment : BaseAssignment
    {
        public const int NotUsed = 0;
        public string KeyScancode { get; set; }
        public int KeyModifierId { get; set; }
        public string ComboScancode { get; set; }
        public int ComboModifierId { get; set; }
        public int UIAttributeId { get; set; }

        public KeyboardAssignment(string callback, int soundId, string keyScancode, int keyModifierId,
            string comboScancode, int comboModifierId, int uiAttributeId, string description)
        {
            Callback = callback;

            KeyScancode = keyScancode;
            KeyModifierId = keyModifierId;

            SoundId = soundId;
            ComboScancode = comboScancode;
            ComboModifierId = comboModifierId;
            UIAttributeId = uiAttributeId;
            Description = description;
        }

        public override string ToString()
        {
            return
                $"{Callback} {SoundId} {NotUsed} {KeyScancode} {KeyModifierId} " +
                $"{ComboScancode} {ComboModifierId} {UIAttributeId} \"{Description}\"";
        }
    }
}