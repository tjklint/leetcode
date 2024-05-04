public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> hashNums1 = new HashSet<int>(nums1);
        HashSet<int> hashNums2 = new HashSet<int>(nums2);

        IList<int> uniqueNums1 = new List<int>();
        IList<int> uniqueNums2 = new List<int>();

        foreach (int num in hashNums1) {
            if (!hashNums2.Contains(num)) {
                uniqueNums1.Add(num);
            }
        }

        foreach (int num in hashNums2) {
            if (!hashNums1.Contains(num)) {
                uniqueNums2.Add(num);
            }
        }

        IList<IList<int>> combinedArray = new List<IList<int>> { uniqueNums1, uniqueNums2 };

        return combinedArray;
    }
}
