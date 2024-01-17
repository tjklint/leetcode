public class Solution {
    public string ReverseVowels(string s) {
        char[] chars = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            while (left < right && !IsVowel(chars[left])){
                left++;
            }

            while (left < right && !IsVowel(chars[right])) {
                right--;
            }

            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;

            left++;
            right--;
        }
        return new String(chars);
    }

    bool IsVowel(char c) {
        c = Char.ToLower(c);
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
