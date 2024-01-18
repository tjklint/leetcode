public class Solution {
    public int Compress(char[] chars) {
        int indexAns = 0;

        for (int index = 0; index < chars.Length; index++) {
            char currentChar = chars[index];
            int count = 1;

            for (; index + 1 < chars.Length && chars[index + 1] == currentChar; index++) {
                count++;
            }

            chars[indexAns++] = currentChar;

            if (count != 1) {
                foreach (char c in count.ToString()) {
                    chars[indexAns++] = c;
                }
            }
        }

        return indexAns;
    }
}
