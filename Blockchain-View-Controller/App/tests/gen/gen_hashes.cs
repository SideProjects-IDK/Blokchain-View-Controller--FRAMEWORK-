//using System;

//class MyException(ApplicationException)
//{
//    public:
//	this(string msg) : base(msg) {}
//}

//class A
//{
//    public:
//	shared void Main()
//    {

//        List<string> Characters = ["a", "b", "c", "d", "e", "f", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"];

//        List<string> Hashes = [];

//        foreach (var _v in Characters)
//        {
//            foreach (var _w in Characters)
//            {
//                foreach (var _x in Characters)
//                {
//                    foreach (var _y in Characters)
//                    {
//                        foreach (var _z in Characters)
//                        {
//                            string Generated_Hash = $"0x{_v}{_w}{_x}{_y}{_z}";
//                            Hashes.Add(Generated_Hash);
//                        }
//                    }
//                }
//            }
//        }


//        System.IO.File.WriteAllText("./hashes.txt", Hashes.ToString());
//    }
//}