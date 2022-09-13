namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums ={2,7,11,15};
            int target = 9;

            int[] result = TwoSum(nums, target);
            Console.WriteLine(string.Join(" ", result));
            
        }

        private static int[] TwoSum(int[] nums, int target)
        {
            int length = nums.Length;
            Dictionary<int, int> dict = new();

            for(int i = 0; i < length;i++)
            {
                int firstNum =  nums[i];
                int diff = target - firstNum;
                if(dict.TryGetValue(diff, out int index))
                {
                    return new int[] {index, i};
                    
                }
                dict[firstNum] = i;
            }
            return Array.Empty<int>();
        }
    }
}