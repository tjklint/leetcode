function letterCombinations(digits: string): string[] {
    // Edge case where digits is empty.
    if (digits.length === 0) {
        return [];
    }
    
    const map = {
            "2": ["a", "b", "c"],
            "3": ["d", "e", "f"],
            "4": ["g", "h", "i"],
            "5": ["j", "k", "l"],
            "6": ["m", "n", "o"],
            "7": ["p", "q", "r", "s"],
            "8": ["t", "u", "v"],
            "9": ["w", "x", "y", "z"]
        };

        let size = 1;
        
        for (let i = 0; i < digits.length; i++) {
            size *= map[digits[i]].length;
        }

        const result = new Array(size).fill("");
        let repeatAcc = 1;

        for (let i = 0; i < digits.length; i++) {
            const lettersCount = map[digits[i]].length;
            const repeat = (size / lettersCount) / repeatAcc;

            for (let j = 0; j < size; j++) {
                result[j] += map[digits[i]][Math.floor(j / repeat) % lettersCount];
            }

            repeatAcc *= lettersCount
        }

        return result;
        
};
