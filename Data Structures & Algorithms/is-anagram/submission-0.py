class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        my_dict = dict()
        t_dict = dict()
        for charS in s:
            my_dict[charS] = my_dict.get(charS,0) +1
        for charT in t:
            t_dict[charT] = t_dict.get(charT,0) +1

        return my_dict == t_dict


        