func finalValueAfterOperations(operations []string) int {
    count := 0

    for _, val := range operations {
        if val[1] == '+' {
            count++
        } else {
            count--
        }
    }

    return count
}
