public class Solution {
    public bool UniqueOccurrences(int[] arr) {

        // List to store unique numbers found.
        List<int> uniqueNumbers = new List<int>();
        // List to store occurences of each unique number found.
        List<int> counts = new List<int>();

        foreach (int num in arr) {
            // Check if the number is already in the list of uniqueNumbers.
            int index = uniqueNumbers.IndexOf(num);
            if (index != -1) {
                // If the number exists, add 1 to that index.
                counts[index]++;
            }
            else {
                // If the number is not found add to the list, and      
                // initialize to 1.
                uniqueNumbers.Add(num);
                counts.Add(1);
            }
        }

        HashSet<int> uniqueNums = new HashSet<int>();
        foreach (int count in counts){
            // Check if the count is already in the HashSet.
            if (uniqueNums.Contains(count)) {
                // If a duplicate amount is found, return false.
                return false;
            }
            uniqueNums.Add(count);
        }

        // If all passes, return true.
        return true;
    }
}
