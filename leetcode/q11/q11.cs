public class Solution {
    public int MaxArea(int[] height) {
        int answer = 0;
        int i = 0;
        int j = height.Length - 1;
        
        while (i < j) {
            int width = j - i;
            int conHeight = 0;

            if (height[j] > height[i]) {
                conHeight = height[i];
                i++;
            }
            else {
                conHeight = height[j];
                j--;
            }

            int area = conHeight * width;
            answer = Math.Max(area, answer);
        }

        return answer;
    }
}
