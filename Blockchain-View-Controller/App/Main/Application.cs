using Blockchain_View_Controller.App.Assets.Lists;
using Blockchain_View_Controller.App.tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_View_Controller.App.Main
{
    public class Application
    {
        public class Developement
        {
            public static bool IsDebugModeOn = true;

            public class Defined
            {
                public class Errors
                {
                    public static List<string> _Addresses =
                       [
                        "0x00001",
                        "0x00002",

                        "0x00003",
                        "0x00004",
                        "0x00005",

                        "0x00006",

                        "0x00007",
                        "0x00008",
                        "0x00009",
                       ];

                    public static List<string> _Messaegs =
                        [
                        "Not-Implemented-Error",
                        "Program-Logic-Error",

                        "Account-Login-Error",
                        "Account-NotFound-Error",
                        "Account-AlreadyExists-Error",

                        "Not-Enough-Balance-Error",

                        "Currency-NotFound-Error",
                        "Currency-ALreadyExists-Error",
                        "Currency-AdminAccount-Login-Error",

                        ];

                    // More errors are here: Blockchain_View_Controller.App.Assets.Lists.my_errors
                }
            }
        }
        public static void __main__()
        {
            //STARTUP
            startup.config_errors.Config(
                Developement.Defined.Errors._Addresses,
                Developement.Defined.Errors._Messaegs
                );
            //


            ///////////////////////////////////////////////////////
            //                                                   //  
            // You can create amazing apps using this frmaework, //
            //                                                   //
            // A example program will be published soon!         //   
            //                                                   //
            ///////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Go visit: https://hmza-sfyn.github.io/sideprojects_idk/blockchain_view_controller/index.html for more info  //
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            zzo.RunTests();
        }
    }
}
