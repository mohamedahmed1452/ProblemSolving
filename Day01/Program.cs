namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {

           var x=TwoSum([2, 7, 11, 15],9);
            foreach(var v in x)
            {
                Console.WriteLine(v);
            }
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            for(var i = 0; i < nums.Length; i++)
            {
                for(var j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                        return  [ i, j ];
                }
            }
            return [];

        }
    }
}
