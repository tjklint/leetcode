class Solution {

    /**
     * @param String $word1
     * @param String $word2
     * @return String
     */
    function mergeAlternately($word1, $word2) {
        $answer = "";

        for ($i = 0; $i < strlen($word1) || $i < strlen($word2); $i++) {
            if ($word1[$i]) {
                $answer .= $word1[$i];
            }
            if ($word2[$i]) {
                $answer .= $word2[$i];
            }
        }

        return $answer;
    }
}
