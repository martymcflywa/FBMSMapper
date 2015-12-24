using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models.Device
{
    public class Joystick
    {
        public readonly UserConfiguration UserConfiguration;

        public int JoystickId { get; set; }
        public int NumberOfButtons { get; set; }
        public int Offset => JoystickId * Constants.Offset;

        public Joystick(UserConfiguration userConfiguration, int joystickId, int numberOfButtons)
        {
            UserConfiguration = userConfiguration;
            JoystickId = joystickId;
            NumberOfButtons = numberOfButtons;
        }
    }
}