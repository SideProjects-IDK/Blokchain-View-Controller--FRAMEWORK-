using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_View_Controller.App.Main.startup
{
    public class config_errors
    {
        public static bool Config(List<string> _Addresses,List<string> _Messaegs)
        {
            for (int i = 0; i < _Addresses.Count; i++)
            {
                controller.custom.exceptions.ErrorList.Get.Error.Err_Addresses.Add(_Addresses[i]);
                controller.custom.exceptions.ErrorList.Get.Error.Err_Messaegs.Add(_Messaegs[i]);
            }

            return true;
        }
        public static void ListErrors()
        {
            Console.WriteLine($"+ {"-----------------------------------",+35}+{"--------------------------------------------------",+50}+");
            Console.WriteLine($"| {"Addresses",-35}|{"Value/Messages",-50}|");
            for (int i = 0; i < (
                controller.custom.exceptions.ErrorList.Get.Error.Err_Addresses.Count
                + controller.custom.exceptions.ErrorList.Get.Error.Err_Messaegs.Count / 2
                ); i++)
            {
                Console.WriteLine($"| {controller.custom.exceptions.ErrorList.Get.Error.Err_Addresses[i],-35}|{controller.custom.exceptions.ErrorList.Get.Error.Err_Messaegs[i],-50} |");
            }
            Console.WriteLine($"+ {"-----------------------------------",+35}+{"--------------------------------------------------",+50}+");

        }
    }
}
