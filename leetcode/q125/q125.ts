function isPalindrome(s: string): boolean {
    s = s.toLowerCase();

    let j = s.length - 1;

    for (let i = 0; i < j;) {
        let iChar = s.charCodeAt(i);
        let jChar = s.charCodeAt(j);

        
        while (!isAlphanumeric(iChar)) {
            i++
            if (i === j) return true
            iChar = s.charCodeAt(i);
        }

        while (!isAlphanumeric(jChar)) {
            j--
            if (i === j) return true
            jChar = s.charCodeAt(j);
        }
    
        if (iChar !== jChar) return false

        i++ 
        j--
    }

    return true



};


function isAlphanumeric(code: number) {
    return ((code >= 48 && code <= 57) || (code >= 97 && code <= 122)) 
}
