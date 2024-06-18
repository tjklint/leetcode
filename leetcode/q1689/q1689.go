func minPartitions(n string) int {
    result := 0

    for _, num := range n {
        result = max(result, int(num - '0'))
    }

    return result
}
