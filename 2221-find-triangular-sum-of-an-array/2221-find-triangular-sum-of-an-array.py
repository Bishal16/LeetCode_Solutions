class Solution:
    def triangularSum(self, nums: List[int]) -> int:
        if len(nums)==1:
            return nums[0]
        lst1 = nums
        lst2 = []
        while len(lst1) != 2:
            for i in range(len(lst1)-1):
                lst2.append((lst1[i] + lst1[i+1])%10)
            lst1 = lst2
            lst2 = []            
        return (lst1[0]+lst1[1])%10