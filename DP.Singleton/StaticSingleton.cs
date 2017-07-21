using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Singleton
{
    /// <summary>
    /// 静态单例模式实现（实现方式一和实现方式二两种实现效果是一样的）
    /// </summary>
    public class StaticSingleton
    {
        #region 实现方式一
        //public static readonly StaticSingleton Instance = new StaticSingleton();

        ///// <summary>
        ///// 私有化构造函数，为了使该单利无法在外面直接通过new关键字构建
        ///// </summary>
        //private StaticSingleton()
        //{
        //    Console.WriteLine("构造实例...");
        //}
        #endregion

        #region 实现方式二
        public static readonly StaticSingleton Instance;

        /// <summary>
        /// 私有化构造函数，为了使该单利无法在外面直接通过new关键字构建
        /// </summary>
        private StaticSingleton()
        {
            Console.WriteLine("构造实例...");
        }

        static StaticSingleton()
        {
            Instance = new StaticSingleton();
        } 
        #endregion

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
