public class Solution {
    public int PivotIndex(int[] nums) {
        if(nums.Length==1)
            return 0;
        int sum=0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
        }
        int leftsum=0;
        int rightsum=0;
        for(int i=0;i<nums.Length;i++){
            if(i==0)
                leftsum=0;
            else
                leftsum+=nums[i-1];
            rightsum=sum-(leftsum+nums[i]);
            if(leftsum==rightsum)
                return i;
        }
        return -1;
    }
}