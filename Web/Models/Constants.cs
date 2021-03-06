﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public static class Constants
    {
        public enum Categories
        {
            UIAndThirdParty = 1,
            HOTAS,
            LeftConsole,
            LeftAuxConsole,
            CenterConsole,
            RightConsole,
            Miscellaneous,
            Views,
            RadioCOMMS
        }

        public enum Countries
        {
            US,
            German,
            French
        }

        public const int Offset = 32;
        public const int MaxButtons = 512;
        public const int MaxDevices = 16;
        public const int DefaultShiftMagnitude = 256;
        public const int DefaultNumberOfDevices = 8;

        public const int NoSoundKey = -1;
        public const int NoSoundDX = 0;
        public const int NotInUse = 0;
        public const int Visible = 1;

        public const int TypeDX = -2;
        public const int TypeHat = -3;

        public const int EventPress = 0;
        public const int EventRelease = 0x42;
    }
}