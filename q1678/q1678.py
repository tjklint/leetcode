class Solution:
    def interpret(self, command: str) -> str:
        response = []
        for i in range(len(command)):
            if command[i] == "G":
                response.append("G")
            elif command[i] == "(":
                if command[i + 1] == ")":
                    response.append("o")
                elif command[i + 1] == "a":
                    response.append("al")
        return "".join(response)
