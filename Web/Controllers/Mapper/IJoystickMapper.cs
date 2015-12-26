using System.Collections.Generic;
using Web.Models.Device;

namespace Web.Controllers.Mapper
{
    public interface IJoystickMapper : IMapper
    {
        List<JoystickAssignment> Assignments { get; set; }

        void AddAssignment(string callback, int buttonNumber, int invocationId, bool isHat, bool isPress, int soundId,
            string description);

        void RemoveAssignment(string callback, int buttonNumber);
    }
}