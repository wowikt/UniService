using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UniService.Wcf.DataContracts
{
    [DataContract]
    public class ConversionRequest
    {
        [DataMember]
        public string TextInput { get; set; }
    }
}
