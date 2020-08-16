using System;
using System.Threading;

namespace CSharpMenu
{
    public class SleepAndClear
    {
        public void ForSigIn()
        {
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
