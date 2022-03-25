using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallengeMar25
{
    public class Question2
    {
        public static void Answer()
        {
            Dictionary<char, int> myHashtable = new Dictionary<char, int>();
            string s = "abbb";
            bool isvalid = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (myHashtable.ContainsKey(s[i]))
                {
                    myHashtable[s[i]] = (int)myHashtable[s[i]] + 1;
                }
                else
                {
                    myHashtable.Add(s[i],1);
                }
            }

            List<int> nums = new List<int>();
            List<int> numsB = new List<int>();
            foreach (var item in myHashtable.Values)
            {
                if (!nums.Contains(item))
                {
                    nums.Add(item);
                }
                else
                {
                    numsB.Add(item);
                }
            }
            
            if (nums.Count == 1)
            {
                isvalid = true;
            }

            if (nums.Count > 2)
            {
                isvalid = false;
            }

            if (nums.Count == 2 && numsB.Count!=0)
            {
                if (numsB.Count != 0 && numsB.Max() > nums.Max())

                {
                    isvalid = false;
                }
                if (numsB.Count != 0 && nums.Max() - numsB.Max() == 1)

                {
                    isvalid = true;
                }
            }

            if (nums.Count == 2 && numsB.Count == 0)
            {
                if (nums[0] - nums[1] == 1 || nums[0] - nums[1] == -1)
                {
                    isvalid = true;
                }
                else
                {
                    isvalid = false;
                }
            }

            Console.WriteLine(isvalid);
        }
    }
    
}