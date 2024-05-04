function tribonacci(n: number): number {
    // Edge cases.
    if (n === 0) return 0;
    if (n === 1 || n === 2) return 1;
    
    // Start it off with the first 3 numbers, and we'll skip the counter up 3 as well.
    const tribArr: number[] = [0,1,1];
    let i: number = 3;

    // Update the 3-index array until completion.
    do { 
        tribArr[i] = tribArr[i-3] + tribArr[i-2] + tribArr[i++ - 1];
    } while (i <= n);
    return tribArr[n]
};
