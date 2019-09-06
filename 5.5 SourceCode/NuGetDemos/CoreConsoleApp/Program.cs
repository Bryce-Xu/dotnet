using System;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var libInfo = MyClassLibrary.LibraryInfo.About();
            //输出：一个目标框架为.NET Standard的类库
            Console.WriteLine(libInfo);
        }
    }
}
