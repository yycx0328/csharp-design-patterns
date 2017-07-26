using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace DP.SimpleFactory
{
    public class Factory
    {
        public static readonly string CAR = ConfigurationManager.AppSettings["CAR"];

        /// <summary>
        /// 利用反射创建对象，这样实现了实例与工厂之间的解耦，
        /// 当我们再增加一个国家印度，只需要India实现ICountry接口，
        /// 可以不用修改Factory工厂类，上端使用时只需要在配置中配置India便可。
        /// </summary>
        /// <returns></returns>
        public ICar CreateInstance()
        {
            string[] setting = CAR.Split(',');
            // 通过给定程序集的长格式名称加载程序集
            Assembly assembly = Assembly.Load(setting[0]);
            // 使用区分大小写的搜索，从此程序集中查找指定的类型，然后使用系统激活器创建它的实例
            return (ICar)assembly.CreateInstance(setting[1]);
        }
    }
}
