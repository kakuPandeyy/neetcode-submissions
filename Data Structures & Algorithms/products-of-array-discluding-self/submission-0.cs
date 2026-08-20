public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        int[] prefix = new int[nums.Length];
        int[] sefix  = new int[nums.Length];
        int[] result = new int[nums.Length];


        for(int i =0 ; i< nums.Length; i++){
            
            if(i == 0 ){
                prefix[i] = nums[i];
                continue;
            }
            
            prefix[i] =  prefix[i-1]*nums[i];
        }

         for(int j =nums.Length-1 ; j>=0; j--){
            
            if(j == nums.Length-1 ){
                sefix[j] = nums[j];
                continue;
            }
          
              sefix[j] =  nums[j]*sefix[j+1];
        }

        for(int k = 0 ; k < nums.Length; k++){
            if(k == 0){

                result[k] = sefix[k+1];

            }
            else if( k == nums.Length -1){
                result[k] = prefix[k-1];
            }
            else{
                result[k] = prefix[k-1]*sefix[k+1];
            }


        }

        return result;


        
    }
}
