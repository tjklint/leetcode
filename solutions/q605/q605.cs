public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {

        int flowers = 0;

        for (int i = 0; i < flowerbed.Length; i++) {
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] != 1) 
            && (i == flowerbed.Length - 1 || flowerbed[i + 1] != 1)){
                flowerbed[i] = 1;
                flowers++;
            }
        }

        return flowers >= n;
    }
}
