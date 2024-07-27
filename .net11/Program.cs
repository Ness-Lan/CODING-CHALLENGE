public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
            
         int [] result= new int[2];

        for (int i=0; i < nums.Length; i++)
        {
            for(int j=1; i < nums.Length; i++)
            {
                         
               if (nums [i] + nums [i+j]==target)
               {
                   result[0] = i;
                   result[1] = i+j;
                return result;               
                 }
              
        }
    

       }
        return result; 
    }
       
}
