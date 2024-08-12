type P = Promise<number>

async function addTwoPromises(promise1: P, promise2: P): P {
    let result: number = 0;
    result += (await promise1).valueOf();
    result += (await promise2).valueOf();

    return result;
};

/**
 * addTwoPromises(Promise.resolve(2), Promise.resolve(2))
 *   .then(console.log); // 4
 */
