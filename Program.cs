using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrampGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 1～4の数字を入力するフォームを4つ用意する。
            for(int i = 0; i < 4; i++)
            {
                Console.Write("{0}番目のカードを入力してください。 > ",i + 1);
                Console.ReadLine();
            }
            Console.ReadLine() ;
        }
    }
}
