public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

     Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
       



     for(int i =0 ; i < strs.Length; i++){

          char[] charArr = strs[i].ToCharArray();
          Array.Sort(charArr);
          string sortedString = new string(charArr);
             if (!map.ContainsKey(sortedString))
                    map[sortedString] = new List<string>();
             map[sortedString].Add(strs[i]);

       }

       return map.Values.ToList();
        
      


}
    // public static bool isAnagram(string word1,string word2){
    //     if(word1.Length != word2.Length){
    //         return false;
    //     }
    //     Dictionary<char,int> wordMap = new Dictionary<char,int> ();
    //     for(int i = 0; i < word1.Length;i++){
    //         if(wordMap.TryGetValue(word1[i],out int feq )){
    //             wordMap[word1[i]] = ++feq; 
    //         }else{
    //             wordMap[word1[i]] = 1;
    //         }
    //     }

    //     for (int j =0; j < word2.Length; j++){
    //         if(wordMap.TryGetValue(word2[j],out int feq)){
    //             wordMap[word2[j]] = --feq; 
    //         }else{
    //             return false;
    //         }
    //     }
    //     return wordMap.Values.All(x => x ==0 );

  


        
    
}
