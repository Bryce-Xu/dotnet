using System;
//添加对于引用项目命名空间的引用
using MyStandardLibrary;
using Newtonsoft.Json;

namespace DotNetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseClassesInMyStandardLibrary();

            UseClassesInNewtonSoftJson();

        }

        //使用通过NuGet安装的Newtonsoft.json包中的类
        private static void UseClassesInNewtonSoftJson()
        {
            var obj = new MyClass()
            {
                Value = 100,
                info = "Hello,Newtonsoft.json"
            };
            //输出：{"Value":100,"info":"Hello,Newtonsoft.json"}
            Console.WriteLine($"{JsonConvert.SerializeObject(obj)}");
        }

        private static void UseClassesInMyStandardLibrary()
        {
            //调用MyStandardLibrary中类的方法
            Console.WriteLine(LibraryInfo.About());
            Console.WriteLine($"100+200={MathFunc.Add(100, 200)}");
        }
    }
}



