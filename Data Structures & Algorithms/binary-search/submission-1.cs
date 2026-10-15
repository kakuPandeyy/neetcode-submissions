public class Solution {
    public int Search(int[] nums, int target) {
        
        int start = 0;
        
        int end = nums.Length - 1;

        while(end >= start){
            int mid = (start + end)/2;

            if(nums[mid] == target){
                return mid;
            }
            if (nums[mid] > target){
                end = mid -1 ;
                continue;
            }else{
                start = mid + 1 ;
                continue;
            }
            
        }
        return -1;
    }
}
