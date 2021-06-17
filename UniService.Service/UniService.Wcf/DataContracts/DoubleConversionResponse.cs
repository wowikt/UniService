﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UniService.Wcf.DataContracts
{
    [DataContract]
    public class DoubleConversionResponse
    {
        [DataMember]
        public double Result { get; set; }

        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }
    }
}
