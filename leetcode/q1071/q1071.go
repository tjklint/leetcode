func gcdOfStrings(str1 string, str2 string) string {
    gcd := func(a, b int) int {
        for b != 0 {
            // Using the Euclidean algorithm, replace (a, b) with (b, a % b) until b is 0.
            a, b = b, a % b
        }
        return a
    }

    // Edge case: Concatenating str1 with str2 is the same as doing str2 with str1.
    if str1 + str2 != str2 + str1 {
        return ""
    }

    // Get the GCD by calling the function.
    gcdLength := gcd(len(str1), len(str2))

    // Return the first string prefix by getting the first letters until gcdLength.
    return str1[:gcdLength]
}
