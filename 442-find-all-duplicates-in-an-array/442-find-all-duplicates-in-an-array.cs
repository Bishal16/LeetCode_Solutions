public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var sett = new HashSet< int>();
        var ans = new List <int>();
        
        foreach(int i in nums){
            if (sett.Contains(i)) ans.Add(i);                
            else sett.Add(i);                
        }
        return ans;        
    }
}