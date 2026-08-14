public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var arr = new (int value,int index)[nums.Length];
        for(int t = 0;  t < nums.Length; t++){
            arr[t] = (nums[t],t);

        }
        Array.Sort(arr , (a, b) => a.value.CompareTo(b.value));
        int i = 0;
        int j= nums.Length-1;
        while( i < j ){

            int sum = arr[i].value + arr[j].value;
            if(sum == target){
                 return new int[]
                {
                    Math.Min(arr[i].index, arr[j].index),
                    Math.Max(arr[i].index, arr[j].index)
                };
            }
            if(sum > target){
                j--;
                continue;
            }
            if(sum < target){
                i++;
                continue;
            }

        }
        return new int[]{};

    }
}
