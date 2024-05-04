class Solution {
public:
    string mergeAlternately(string word1, string word2) {
        int n = word1.length();
        int m = word2.length();

        int i = 0;
        int j = 0;

        string ans = "";

        while (i < n && j < m) {
            ans += word1[i];
            ans += word2[j];
            i++;
            j++;
        }
        while (i < n) {
            ans += word1[i];
            i++;
        }
        while (j < m) {
            ans += word2[j];
            j++;
        }
        return ans;
    
    }
};
