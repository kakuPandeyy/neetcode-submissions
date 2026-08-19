public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int,int> map = new Dictionary<int,int>();
        
        List<int>[] arr = new List<int>[nums.Length+1];

        foreach( int num in nums){

           if (map.TryGetValue(num, out int feq)){
            map[num] = ++feq;
           }else{
            map[num] = 1;
           }

        }
         
        foreach(var item in map){

            if(arr[item.Value] != null){
                 arr[item.Value].Add(item.Key);
            }else{
                arr[item.Value] = new List<int>();
                 arr[item.Value].Add(item.Key);
            }
        }
        int resIndex = k;
        List<int> result = new List<int>();

        for(int index = arr.Length -1; resIndex > 0 && index > 0; index--)       {
            if (arr[index] == null)
               continue;

            foreach(int resNum in arr[index] ){
                result.Add(resNum);
                resIndex --;
            }


        }
        return result.ToArray();




        
    }
}
