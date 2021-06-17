using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniService.Wcf.DataContracts;
using UniService.Wcf.ServiceContracts;

namespace UniService.Business.Services
{
    public class UniService : IUniService
    {
        public DoubleConversionResponse ConvertToDouble(ConversionRequest req)
        {
            if (double.TryParse(req.TextInput, out double value))
            {
                return new DoubleConversionResponse
                {
                    Result = value,
                    Success = true,
                    ErrorMessage = string.Empty,
                };
            }

            return new DoubleConversionResponse
            {
                Success = false,
                ErrorMessage = "Cannot parse value",
            };
        }

        public IntConversionResponse ConvertToInt(ConversionRequest req)
        {
            if (int.TryParse(req.TextInput, out int value))
            {
                return new IntConversionResponse
                {
                    Result = value,
                    Success = true,
                    ErrorMessage = string.Empty,
                };
            }

            return new IntConversionResponse
            {
                Success = false,
                ErrorMessage = "Cannot parse value",
            };
        }
    }
}
