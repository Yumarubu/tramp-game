using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrampGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cardnumber;
            bool onepea = false;
            bool twopea = false;
            bool threecard = false;
            bool fourcard = false;

            int wcard = 0;

            //カードに書かれている数字
            int[] card = new int[4];

            //カードの枚数
            int[] numberscard = new int[4];
            Random rand = new Random();
            rand.Next(1,5);

            //1. 1～4の数字を入力するフォームを4つ用意する。
            for (int i = 0; i < card.Length; i++)
            {
                Console.Write("{0}番目のカードを入力してください。 > ",i + 1);
                cardnumber = Console.ReadLine();
                int CardNumber = int.Parse(cardnumber); 
                card[i] = CardNumber;
            }
            Console.ReadLine();

            //カードの枚数分まで回す
            for (int count = 0; count < numberscard.Length; count++)
            {
                //カードの最大値分回す
                for (int numbercount = 0; numbercount < numberscard.Length; numbercount++)
                {
                    //カードの枚数とその最大値を比較して、カードの数値を足していく
                    if (card[count] == numbercount + 1)
                    {
                        numberscard[numbercount]++;
                    }
                }
            }

            //カードの枚数分から、同じ数値を特定する
            for(int item = 0; item < card.Length; item++)
            {
                //・２つの数値が同じ（例：1, 1, 2, 3）→ワンペア
                if (numberscard[item] == 2)
                {
                    wcard++;
                    onepea = true;
                }

                //・２つの数値が同じ×２（例：1, 1, 2, 2）→ツーペア
                if (wcard == 2)
                {
                    twopea = true;
                }

                //・３つの数値が同じ（例：1, 1, 1, 2）→スリーカード
                if (numberscard[item] == 3)
                {
                    threecard = true;
                }

                //４つの数値が同じ（例：1, 1, 1, 1）→フォーカード
                if (numberscard[item] == 4)
                {
                    fourcard = true;
                }
            }

            //3. 判定結果を出力する
            if (fourcard == true)
            {
                Console.WriteLine("フォーカード！");
            }
            else if (threecard == true)
            {
                Console.WriteLine("スリーカード！");
            }
            else if (twopea == true)
            {
                Console.WriteLine("ツーペア！");
            }
            else if (onepea == true)
            {
                Console.WriteLine("ワンペア！");
            }

            //2. 入力された4つの値を確認し、以下の判定を行う。・４つの数値が全て違う（例：1, 2, 3, 4）→ノーペア
            if (onepea == false && twopea == false && threecard == false && fourcard == false)
            {
                Console.WriteLine("ノーペア...");
            }

            Console.ReadLine();
        }

        static void Judge()
        {

        }
    }
}
