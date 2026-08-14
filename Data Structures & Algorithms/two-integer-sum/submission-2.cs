public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if(map.TryGetValue(diff,out int index)){
                return new int[]{index,i};
            }
            map[nums[i]] = i;
        }
        return new int[]{};
    }
}
