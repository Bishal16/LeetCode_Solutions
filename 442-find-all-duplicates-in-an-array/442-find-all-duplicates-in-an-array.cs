public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var dict = new Dictionary<int, int>();
        var ans = new List <int>();
        foreach(int i in nums){
            if (dict.ContainsKey(i))
                ans.Add(i);
            else
                dict[i] = 1;
        }
        return ans;        
    }
}