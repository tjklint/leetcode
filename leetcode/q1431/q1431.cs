public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        // Create the array we will return with the length of all the kids.
        bool[] candyArr = new bool[candies.Length];

        // Iterate through all the kids.
        for (int i = 0; i < candies.Length; i++) {
            // Calculate the sum of the original candies + extras.
            int candyTotal = candies[i] + extraCandies;
            
            // Assume true, unless proven false.
            bool greatest = true;
            
            // Iterate through every other kid.
            for (int j = 0; j < candies.Length; j++) {
                // As long as the amount is bigger, skip.
                if (candyTotal < candies[j]) {
                    greatest = false;
                }
            }

            // Add to the array.
            candyArr[i] = greatest;
        }

        // Return the array.
        return candyArr;
    }
}
