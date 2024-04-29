function isSubsequence(s: string, t: string): boolean {
    if (s === t) {
        return true
    }
    if (s.length > t.length){
        return false
    } 

    let left = 0

    for (let right = 0; right < t.length; right++) {
        if (s[left] === t[right]) {
            left++
        }
        if (left === s.length) {
            return true
        }
    }

    return false
};
