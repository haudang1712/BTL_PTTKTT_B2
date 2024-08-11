using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void CoinChange(int[] coins, int amount)
        {
            Array.Sort(coins);
            Array.Reverse(coins);

            List<int> result = new List<int>();

            for (int i = 0; i < coins.Length; i++)
            {
                while (amount >= coins[i])
                {
                    amount -= coins[i];
                    result.Add(coins[i]);
                }
            }

            if (amount == 0)
            {
                Console.WriteLine("Số lượng đồng xu tối thiểu là: " + result.Count);
                Console.WriteLine("Các đồng xu được chọn là:");
                foreach (var coin in result)
                {
                    Console.Write(coin + " ");
                }
            }
            else
            {
                Console.WriteLine("Không thể đổi được số tiền này với các mệnh giá đã cho.");
            }
        }

        static void Main()
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
            Console.OutputEncoding = UnicodeEncoding.Unicode;
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 };
            int amount = 93;  
            CoinChange(coins, amount);
            Console.ReadKey();
        }
    }

}
