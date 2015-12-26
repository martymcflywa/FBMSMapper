using System;
using System.Collections.Generic;
using System.Linq;
using Web.DataAccess.Repositories;
using Web.Models.Device;

namespace Web.Controllers.Mapper
{
    public class JoystickMapper : IJoystickMapper
    {
        public List<JoystickAssignment> Assignments { get; set; }

        public void AddAssignment(string callback, int buttonNumber, int invocationId, bool isHat, bool isPress, int soundId,
            string description)
        {
            Assignments.Add(new JoystickAssignment(callback, buttonNumber, invocationId, isHat, isPress, soundId, description));
        }

        public void RemoveAssignment(string callback, int buttonNumber)
        {
            if (buttonNumber < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            int buttonId = buttonNumber - 1;

            var item = Assignments
                .First(c => c.Callback == callback &&
                            c.ButtonId == buttonId);

            Assignments.Remove(item);
        }
    }
}