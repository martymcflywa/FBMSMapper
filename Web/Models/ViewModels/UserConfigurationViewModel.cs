using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Models.ViewModels
{
    public class UserConfigurationViewModel
    {
        [Display(Name = "DX Shifting")]
        public bool IsDXShifting { get; set; }

        [Display(Name = "Keyboard Layout")]
        public int CountryId { get; set; }

        [Display(Name = "Number of Devices")]
        public int NumberOfDevices { get; set; }

        [Display(Name = "Shift Magnitude")]
        public int ShiftMagnitude { get; set; }

        [Display(Name = "Number of Shifted Devices")]
        public int ShiftDevices => Constants.MaxDevices - NumberOfDevices;
    }
}