public class Solution {
    public int MaxConsecutive(int bottom, int top, int[] special) {
        int max = 0, n = special.Length, i;
        Array.Sort(special);
        max = special[0]-bottom;
        for( i = 0; i < n-1; i++){
        if (special[i+1]-special[i]-1 > max)
            max = special[i+1]-special[i]-1;
        }
        if (top-special[n-1] > max)
            max = top-special[n-1];
        return max;
    }
}