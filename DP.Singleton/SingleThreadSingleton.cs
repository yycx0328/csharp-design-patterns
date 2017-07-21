using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Singleton
{
    /// <summary>
    /// 单线程单例模式
    /// </summary>
    public class SingleThreadSingleton
    {
        private static SingleThreadSingleton instance = null;
        
        /// <summary>
        /// 私有化构造函数，为了使该单利无法在外面直接通过new关键字构建
        /// </summary>
        private SingleThreadSingleton() 
        {
            Console.WriteLine("构造实例...");
        }

        /// <summary>
        /// 返回实例
        /// </summary>
        public static SingleThreadSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new SingleThreadSingleton();
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
