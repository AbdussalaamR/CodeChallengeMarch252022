using System;
using System.Collections.Generic;

namespace CodeChallengeMar25
{
    public class Question1
    {
        public static void Answer()
        {
            int n = 5;
            int k = 2;
            int m = k - 1;
            Queue<int> num = new Queue<int>();
            for (int i = 1; i <= n; i++)
            {
                num.Enqueue(i);
            }

            for (int i = 0; i < num.Count; i++)
            {
                
                // if (num.Count == 1)
                // {
                //     break;
                // }
                // else
                // {
                    var a = num.Dequeue();
                    
                    var b = num.Dequeue();
                    if (num.Count == 1)
                    {
                        break;
                    }
                    num.Enqueue(a);
                //}
            }

            foreach (var VARIABLE in num)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}