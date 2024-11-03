using Blockchain_View_Controller.view;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata;

namespace Blockchain_View_Controller
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// To run the main Application, present in: ./App/Min/Application.cs, Function:__main__()
            try
            {
                App.Main.Application.__main__();
            }
            catch (Exception exxe)
            {
                if (App.Main.Application.Developement.IsDebugModeOn)
                {
                    view.@out.p_error(exxe.ToString());
                }
            }
        }
    }
}
