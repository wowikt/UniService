using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using UniService.Wcf.DataContracts;

namespace UniService.Wcf.ServiceContracts
{
    [ServiceContract]
    public interface IUniService
    {
        [OperationContract]
        IntConversionResponse ConvertToInt(ConversionRequest req);

        [OperationContract]
        DoubleConversionResponse ConvertToDouble(ConversionRequest req);
    }
}
