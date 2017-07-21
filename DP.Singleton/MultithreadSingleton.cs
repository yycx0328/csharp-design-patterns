using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Singleton
{
    /// <summary>
    /// 多线程单例模式
    /// </summary>
    public class MultithreadSingleton
    {
        /// <summary>
        /// volatile多用于多线程的环境，当一个变量定义为volatile时，
        /// 读取这个变量的值时候每次都是从momery里面读取而不是从cache读，
        /// 这样做是为了保证无论其他线程如何更新这个变量,读取该变量的信息都是最新的。
        /// </summary>
        private static volatile MultithreadSingleton instance = null;

        /// <summary>
        /// 锁机制
        /// </summary>
        private static object lockObject = new object();

        /// <summary>
        /// 私有化构造函数，为了使该单利无法在外面直接通过new关键字构建
        /// </summary>
        private MultithreadSingleton() 
        { 
            Console.WriteLine("构造实例...");
        }

        public static MultithreadSingleton Instance
        {
            get 
            {
                if (instance == null)
                {
                    // 【标记A】
                    // 实例为空时，开启锁机制保证instance实例在安全状态下构建
                    lock (lockObject)
                    {
                        // 再次确保实例为空的情况下去构建instance实例,
                        // 因为很有可能在构建instance实例时，很多线程在【标记A】处等待，
                        // 在这里可能会有一个疑惑：在外面已经知道instance是空，进到这里面不还是空吗，
                        // 这就是volatile的作用，它保证无论其他线程如何更新instance实例，
                        // 读取到的instance实例信息永远都是最新的，
                        // 如果将声明instance的关键字volatile去掉，这种做法也是不安全的，也可能会创建多个实例
                        if (instance == null)
                        {
                            instance = new MultithreadSingleton();
                        }
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// 【测试方法】加运算
        /// </summary>
        /// <param name="a">数值</param>
        /// <param name="b">数值</param>
        /// <returns>计算结果</returns>
        public int Plus(int a, int b)
        {
            return a + b;
        }
    }
}
