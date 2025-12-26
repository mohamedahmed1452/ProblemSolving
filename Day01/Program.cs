namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var num= MoveZeroes([0,0]);
            foreach(var i in num)
            {
                Console.WriteLine(i);
            }
        }

        #region Day01

        #region Problem 01
        //public static int[] TwoSum(int[] nums, int target)
        //{
        //    for(var i = 0; i < nums.Length; i++)
        //    {
        //        for(var j = 0; j < nums.Length; j++)
        //        {
        //            if (i != j && nums[i] + nums[j] == target)
        //                return  [ i, j ];
        //        }
        //    }
        //    return [];

        //}

        public static int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var res = target - nums[i];//9-2=7   =>9-7=2
                if (map.ContainsKey(nums[i]))
                {
                    return [map[nums[i]], i];
                }
                map[res] = i;
            }
            return [];

        }




        #endregion

        #region Problem 02
        public static bool ContainsDuplicate(int[] nums)
        {
            var map = new Dictionary<int, int>();
            foreach (var i in nums)
                if (!map.ContainsKey(i))
                    map.Add(i, 1);
                else
                {
                    map[i]++;
                    if (map[i] >= 2) return true;
                }


            foreach (var i in map.Values)
                if (i >= 2) return true;


            return false;

        }
        #endregion

        #region Problem03

        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int min = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
                }
                int profit = prices[i] - min;
                if (maxProfit < profit)
                {
                    maxProfit = profit;
                }

            }

            return maxProfit;
        }
        #endregion


        #endregion

        #region Day02

        #region Day01
        public static int[] MoveZeroes(int[] nums)
        {
            int j = 0;
            for(var i=0;i<nums.Length;i++)
            {
                j = i;
                while (j< nums.Length && nums[j] == 0)
                {
                    j++;
                }
                if (j == nums.Length) return nums;
                if (j != i)
                {
                    swap(ref nums[i], ref nums[j]);
                }
            }
            return nums;


        }




        #endregion






        #endregion

        #region Helper FUnction
        public static void swap(ref int n1,ref int n2)
        {
            int tmp = n1;
            n1 = n2;
            n2 = tmp;
        }
        #endregion

    }
}
