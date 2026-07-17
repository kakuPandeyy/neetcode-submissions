class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        my_set = set()
        for i in nums:
            my_set.add(i)
 
        
        return  len(nums)!=len(my_set)


        
        