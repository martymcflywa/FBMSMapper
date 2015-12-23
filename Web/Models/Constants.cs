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
    }
}