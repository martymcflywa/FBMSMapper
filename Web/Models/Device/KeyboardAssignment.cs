using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace Web.Models.Device
{
    public class KeyboardAssignment : BaseAssignment
    {
        public int MouseOrKeyboard { get; set; }
        public string KeyScancode { get; set; }
        public int KeyModifierId { get; set; }
        public int ComboScancodeId { get; set; }
        public int ComboModifierId { get; set; }
        public int UIAttributeId { get; set; }
        // get description from database where CallbackId is a match
        public string Description { get; set; }

        public KeyboardAssignment(string callback, int? soundId, string keyScancode, int keyModifierId,
            int? comboScancodeId, int? comboModifierId, int? uiAttributeId, string description)
        {
            Callback = callback;
            SoundId = soundId ?? Constants.NoSound;
            MouseOrKeyboard = Constants.NotInUse;

            KeyScancode = keyScancode;
            KeyModifierId = keyModifierId;

            // use default values if null
            ComboScancodeId = comboScancodeId ?? Constants.NotInUse;
            ComboModifierId = comboModifierId ?? Constants.NotInUse;
            UIAttributeId = uiAttributeId ?? Constants.Visible;

            Description = description;
        }
    }
}