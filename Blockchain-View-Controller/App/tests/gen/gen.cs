using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_View_Controller.App.tests.gen
{
    public class gen
    {
        public class Product
        {
            public static List<string> ToList_From(List<string> Characters) //, int? minLenght, int? maxLenght)
            {
                List<string> Product = [];

                //if (minLenght == 0)
                //    minLenght = 1;

                //if (maxLenght == 0)
                //    maxLenght = 2;

                foreach (string _k1 in Characters)
                {
                    foreach (string _k2 in Characters)
                    {
                        foreach (string _k3 in Characters)
                        {
                            foreach (string _k4 in Characters)
                            {
                                foreach (string _k5 in Characters)
                                {
                                    string _item = $"0x{_k1}{_k2}{_k3}{_k4}{_k5}";

                                    Product.Add(_item);
                                }
                            }
                        }
                    }
                }

                return Product;
            }
            public static string ToString_From(List<string> Characters) //, int? minLenght, int? maxLenght)
            {
                string Product = "";

                //if (minLenght == 0)
                //    minLenght = 1;

                //if (maxLenght == 0)
                //    maxLenght = 2;

                foreach (string _k1 in Characters)
                {
                    foreach (string _k2 in Characters)
                    {
                        foreach (string _k3 in Characters)
                        {
                            foreach (string _k4 in Characters)
                            {
                                foreach (string _k5 in Characters)
                                {
                                    string _item = $"0x{_k1}{_k2}{_k3}{_k4}{_k5}";

                                    Product = Product + "\n" + (_item);
                                }
                            }
                        }
                    }
                }

                return Product;
            }
        }
    }
}
