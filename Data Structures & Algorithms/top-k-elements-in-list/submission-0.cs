public class Solution {

    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach (int num in nums){
            if(map.TryGetValue(num,out int feq)){
                map[num]= ++feq;
            }else{
                map[num] =1;

            }
        }
        
        List<KeyValuePair<int,int>> resMap = map.ToList();

        resMap.Sort((a,b)=> b.Value.CompareTo(a.Value));

     List<int> keySortedResMap = resMap
    .Select(x => x.Key)
    .ToList();

        List<int> result = new List<int>(); 

        for( int i =0 ; i<k; i++){
            result.Add(keySortedResMap[i]);
        }

        return result.ToArray();


        

    }
}
