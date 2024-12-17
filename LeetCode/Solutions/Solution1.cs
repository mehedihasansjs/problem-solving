namespace LeetCode.Solutions;

public abstract class Solution1
{
    public static int[]? TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var another = target - nums[i];

            if (dict.TryGetValue(another, out var value))
            {
                return [value, i];
            }

            dict[nums[i]] = i;
        }

        return null;
    }
}
