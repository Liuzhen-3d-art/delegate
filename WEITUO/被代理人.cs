using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace WEITUO
{
    //委托（delegate)有许多函数委托和时间在，.Net Framework中的应用非常广泛指针不具备的优点，委托（delegate)既可以引用静态类型，又可以引用非静态成员函数。delegate是面向对象，类型安全，可靠的受控（managed)对象。也就是说，runtime能够摆正delegate指向的一个有效的方法。你无需担心delegate会指向无效地址或越界地址。
    //方法的签名：是参数列表和返回值的统称
    //委托的签名要与方法的签名保持一致
    //委托是一个类
    //委托可以作为方法的回调
    //委托应该应用在多线程中
    //
    public class 代理人
    {

        public void 被代理人(string houseName, string address)
        {

        }
        //public delegate 被代理人(string houseName, string address);

        //委托列表
        //<访问修饰符> delegate 返回值  委托名称(<参数列表>)
        //例如：public delegate 被代理人(string houseName, string address);
        public delegate void SpeakDel();//无参无返回值的委托
        /*声明委托的使用方法*/
        //先声明一个方法，可以是私有方法也可以是公共方法

      void Speak()
        {
            Console.WriteLine("我是翻译官");
        }
       public void SpeakFun()
        {
            Console.WriteLine("我是翻译官");
        }
        /*委托即将要进行的行为*/
        //委托对象是SpeakDel这个类，实例化这个对象可以回调方法
        public void TestDelegate()
        {
            //创建一个委托对象，并使用代理对象执行具体的代理方
           
            SpeakDel speakdel = new SpeakDel(Speak);//委托使用方法名当做参数来使用，在一个方法里调用另一个方法的一种手段叫做委托。
            speakdel();//使用委托声明的变量直接当做无参方法使用
            //
            SpeakDel spdel = SpeakFun;//也可以使用第二种写法直接读取方法。
            
            spdel.Invoke();//使用Invoke方法调用



            SpeakFun(); //普通的方法的调用

            //委托的应用场景
            //1.可以当做方法的回调
            //2.使用应用在多线程

            

            


        }
        //委托是什么；委托是一个密封类型
        public void Test1()
        {
            //第一种方法。反射可以看清一个对象的本质；
           var weituo= typeof(SpeakDel);//这是反射中获取这个类的方法weituo这个变量就是SpeakDel类型
            Console.WriteLine(weituo.IsClass);//这是委托对象SpeakDel这个类中封装好的方法（是否为类）
            Console.WriteLine(weituo.IsSealed);//是否为密封类（）
            var fulei=  weituo.BaseType;//获取它的父类
            Console.WriteLine(fulei.FullName);//获取这个父类的名字
            



        }

       //多播委托；
       public void TsetMultDeletes()
        {
            SpeakDel del = SpeakFun;
        }

    }
}

