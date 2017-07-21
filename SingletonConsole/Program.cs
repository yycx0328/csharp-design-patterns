using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Singleton;

namespace SingletonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 单线程单例模式
            //int result1 = SingleThreadSingleton.Instance.Plus(10, 21);
            //Console.WriteLine(result1);
            //int result2 = SingleThreadSingleton.Instance.Plus(32, 21);
            //Console.WriteLine(result2); 
            #endregion

            #region 多线程单例模式
            //List<Task> list = new List<Task>();
            //TaskFactory factory = new TaskFactory();
            //list.Add(factory.StartNew(new Action(() =>
            //{
            //    int a = 100, b = 12;
            //    Console.WriteLine(a + "+" + b + "=" + MultithreadSingleton.Instance.Plus(a, b)
            //        + ",线程ID:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            //})));
            //list.Add(factory.StartNew(new Action(() =>
            //{
            //    int a = 98, b = 23;
            //    Console.WriteLine(a + "+" + b + "=" + MultithreadSingleton.Instance.Plus(a, b)
            //        + ",线程ID:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            //})));
            //list.Add(factory.StartNew(new Action(() =>
            //{
            //    int a = 33, b = 65;
            //    Console.WriteLine(a + "+" + b + "=" + MultithreadSingleton.Instance.Plus(a, b)
            //        + ",线程ID:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
            //})));

            //Task.WaitAll(list.ToArray()); 
            #endregion

            #region 静态单例模式
            Console.WriteLine(StaticSingleton.Instance.Plus(98, 12)); 
            Console.WriteLine(StaticSingleton.Instance.Plus(23, 199)); 
            #endregion

            Console.ReadKey();
        }
    }
}
