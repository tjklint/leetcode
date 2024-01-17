public class Solution {
    public string ReverseWords(string s) {
        string[] words = s.Trim().Split(' ');
        StringBuilder sb = new StringBuilder();

        for (int i = words.Length - 1; i >= 0; i--) {
            sb.Append($"{words[i]}");
            if (words[i] != "") { if (i > 0) sb.Append(" "); };
        }

        return sb.ToString();
    }
}
