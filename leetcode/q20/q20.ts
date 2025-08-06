function isValid(s: string): boolean {
    let stack: string[] = []
    for (let i = 0; i < s.length; i++) {
        if (s[i] === '(' || s[i] === '{' || s[i] === '[') {
            stack.push(s[i])
        }
        else {
            let closed_bracket: string = s[i];
            if ((closed_bracket === ')' && stack.pop() !== '(') ||
            (closed_bracket === '}' && stack.pop() !== '{') ||
            (closed_bracket === ']' && stack.pop() !== '[')) 
            {
                return false
            }
        }
    }
    return stack.length === 0
};
