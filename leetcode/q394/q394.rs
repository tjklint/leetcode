impl Solution {
    pub fn decode_string(s: String) -> String {
        let mut num = String::from("");
        let mut current = String::from("");
        let mut stack = vec!["".to_string()];

        for c in s.chars(){
            if c.is_numeric() {
                num.push(c);
            }
            else if c == '[' {
                stack.push(current);
                stack.push(num);
                current = "".to_string();
                num = "".to_string();
            }
            else if c == ']' {
                let mut temp = stack.pop().unwrap().parse::<usize>().unwrap();
                current = current.repeat(temp);
                let mut previous = stack.pop().unwrap().to_string();
                current = previous+&current;
            }
            else {current.push(c);}
        }

        current
    }
}
