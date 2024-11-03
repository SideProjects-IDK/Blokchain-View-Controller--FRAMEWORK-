using Blockchain_View_Controller.App.Main.startup;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Blockchain_View_Controller.controller.custom
{
    public class exceptions
    {
        public class ErrorList
        {
            public class Get
            {
                public class Error
                {
                    public static List<string> Err_Addresses = new();
                    public static List<string> Err_Type = new();
                    public static List<string> Err_Messaegs = new();

                    public static List<string> FromDict(string _address)
                    {
                        string _type = "";
                        string _message = "";
                        int _Found_Address_At = 0;

                        try
                        {
                            if (Err_Addresses.Contains(_address))
                            {
                                int x = 0;
                                foreach (string k in Err_Addresses)
                                {
                                    if (k.Equals(_address))
                                    {
                                        _Found_Address_At = x;
                                        break;
                                    }
                                    x++;
                                }
                            }

                            _type = Err_Type[_Found_Address_At];
                            _message = Err_Messaegs[_Found_Address_At];
                        }
                        catch (Exception)
                        {
                            _message = $"#message for developer: error with address `{_address}`: not found";
                        }

                        return new List<string> { _type, _message };
                    }
                }
            }
        }

        public class ErrorFactory
        {
            public class ErrorBuilder
            {
                public static ErrorInfo Instance(string type, string message, string occurredAt)
                {
                    string errorType = string.IsNullOrEmpty(type) || type == "." || type == "x"
                        ? "StdErr"
                        : type;

                    string errorLiteral = string.IsNullOrEmpty(message)
                        ? ErrorList.Get.Error.FromDict(occurredAt)[1]
                        : message;

                    return new ErrorInfo
                    {
                        Message = errorLiteral,
                        Type = errorType,
                        Location = new LocationInfo
                        {
                            LocationEncoded = occurredAt.GetHashCode().ToString(),
                            LocationLiteral = occurredAt,
                            LocationType = "Memory-Address"
                        }
                    };
                }
            }

            public class ErrorInfo
            {
                public string Message { get; set; }
                public string Type { get; set; }
                public LocationInfo Location { get; set; }
            }

            public class LocationInfo
            {
                public string LocationLiteral { get; set; }
                public string LocationType { get; set; }
                public string LocationEncoded { get; set; }
            }
        }
    }
}