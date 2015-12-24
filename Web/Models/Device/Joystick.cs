using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models.Device
{
    public class Joystick
    {
        private readonly DeviceConfiguration _deviceConfiguration;

        public int JoystickId { get; set; }
        public int NumberOfButtons { get; set; }
        public int Offset => JoystickId * Constants.Offset;

        public Joystick(DeviceConfiguration deviceConfiguration, int joystickId, int numberOfButtons)
        {
            _deviceConfiguration = deviceConfiguration;
            JoystickId = joystickId;
            NumberOfButtons = numberOfButtons;
        }
    }
}