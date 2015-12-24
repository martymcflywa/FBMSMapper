using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Web.Models.Device
{
    public class JoystickAssignment : BaseAssignment
    {
        public int ButtonId { get; set; }
        // TODO: Invoication needs to be added to the database
        public int InvocationId { get; set; }
        public int ControlTypeId { get; set; }
        public int EventTypeId { get; set; }
        public const string NotUsed = "0x0";

        public JoystickAssignment(string callback, int buttonNumber, int invocationId, bool isHat, bool isPress,
            int? soundId, string description)
        {
            Callback = callback;

            if (buttonNumber < 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                ButtonId = buttonNumber - 1;
            }

            InvocationId = invocationId;

            ControlTypeId = isHat ? Constants.TypeHat : Constants.TypeDX;
            EventTypeId = isPress ? Constants.EventPress : Constants.EventRelease;

            SoundId = soundId ?? Constants.NoSoundDX;

            Description = description;
        }

        public override string ToString()
        {
            return $"{Callback} {ButtonId} {InvocationId} {ControlTypeId} " +
                $"{EventTypeId} {NotUsed} {SoundId} \"{Description}\"";
        }
    }
}