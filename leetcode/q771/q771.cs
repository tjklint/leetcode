public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        Dictionary<char, int> stoneCount = new Dictionary<char, int>();

        foreach (char stone in stones){
            if (stoneCount.ContainsKey(stone)) {
                stoneCount[stone]++;
            }
            else {
                stoneCount[stone] = 1;
            }
        }

        int totalJewels = 0;

        foreach (char jewel in jewels) {
            if (stoneCount.ContainsKey(jewel)) {
                totalJewels = totalJewels + stoneCount[jewel];
            }
        }

        return totalJewels;
    }
}
