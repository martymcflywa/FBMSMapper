using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models.Device
{
    public class DeviceConfiguration
    {
        protected bool IsDXShifting { get; }
        protected int CountryId { get; set; } = (int) Constants.Countries.US;
        protected int NumberOfDevices { get; set; } = Constants.DefaultNumberOfDevices;
        protected int ShiftMagnitude { get; set; } = Constants.DefaultShiftMagnitude;

        protected int ShiftDevices
        {
            get { return Constants.MaxDevices - NumberOfDevices; }
        }

        public DeviceConfiguration(bool isDXShifting, int? countryId, int? numberOfDevices, int? shiftMagnitude)
        {
            IsDXShifting = isDXShifting;

            // if null, use defaults
            if(countryId == null)
            {
                CountryId = (int)Constants.Countries.US;
            } else
            {
                CountryId = (int)countryId;
            }

            if (numberOfDevices == null)
            {
                NumberOfDevices = Constants.DefaultNumberOfDevices;
            } else
            {
                NumberOfDevices = (int)numberOfDevices;
            }

            if(shiftMagnitude == null)
            {
                ShiftMagnitude = Constants.DefaultShiftMagnitude;
            } else
            {
                ShiftMagnitude = (int)shiftMagnitude;
            }
        }
    }
}