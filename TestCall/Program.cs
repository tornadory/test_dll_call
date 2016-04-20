using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestCall {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct GGGG {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string FirstsName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        public string LastName;

        [MarshalAs(UnmanagedType.U8)]
        public ulong Tall;
    }

    class Program {
        [DllImport("TestDllCall.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisplayHelloFromDLL();

        [DllImport("TestDllCall.dll", EntryPoint = "DisplayHello", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void DisplayHello([MarshalAs(UnmanagedType.Struct)]ref GGGG name);

        static void Main() {
            Console.WriteLine("This is C# program");
            DisplayHelloFromDLL();

            var name = new GGGG() { FirstsName = "王昊", LastName = "ha王昊" };
            DisplayHello(ref name);
            Console.Out.WriteLine(name.FirstsName + " " + name.LastName + " " + name.Tall);
            Console.In.ReadLine();
        }
    }
}
