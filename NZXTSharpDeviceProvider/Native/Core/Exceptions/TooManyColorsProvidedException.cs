﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RGB.NET.Devices.NZXT.Native.Core.Exceptions {
    public class TooManyColorsProvidedException : Exception {

        public TooManyColorsProvidedException() 
            : base("NZXTSharp.Exceptions.TooManyColorsProvidedException; CISS Param Can Handle Max Of 15 Colors.") {

        }

        public TooManyColorsProvidedException(string message)
            : base(message) {

        }
    }
}
