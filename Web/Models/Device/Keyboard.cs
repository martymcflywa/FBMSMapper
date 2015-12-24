using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models.Device
{
    public class Keyboard
    {
        public readonly UserConfiguration UserConfiguration;

        public Keyboard(UserConfiguration userConfiguration)
        {
            UserConfiguration = userConfiguration;
        }
    }
}