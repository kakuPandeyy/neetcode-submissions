class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        count = len(nums)
        res = [0] * (count * 2)
       
        for i in range(count):
          res[i] = nums[i]
          res[i+count] = nums[i]
        
        return res
           