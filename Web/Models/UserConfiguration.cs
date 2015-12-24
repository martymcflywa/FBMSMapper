namespace Web.Models
{
    public class UserConfiguration
    {
        protected bool IsDXShifting { get; }
        protected int CountryId { get; set; }
        protected int NumberOfDevices { get; set; }
        protected int ShiftMagnitude { get; set; }

        protected int ShiftDevices => Constants.MaxDevices - NumberOfDevices;

        public UserConfiguration(bool isDXShifting, int? countryId, int? numberOfDevices, int? shiftMagnitude)
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