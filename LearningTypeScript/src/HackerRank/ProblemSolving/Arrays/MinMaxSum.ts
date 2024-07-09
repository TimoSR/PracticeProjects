export function minMaxSum(arr: number[]): void {

    // Sort the array numerically in ascending order
    // The comparison function (a, b) => a - b ensures that the sort method
    // compares numbers correctly:
    // - If a - b is negative, a is smaller than b, so a comes before b.
    // - If a - b is positive, a is larger than b, so a comes after b.
    // - If a - b is zero, a and b are equal in terms of sorting order.
    arr.sort((a, b) => a - b);

    let max: number = Math.max(...arr);
    let min: number = Math.min(...arr);
    let minSum: number = 0;
    let maxSum: number = 0;

    let minArray: number[] = arr.slice(0, arr.length - 1);
    let maxArray: number[] = arr.slice(1);

    for(let i = 0; i < arr.length - 1; i++) {

        minSum += minArray[i];
        maxSum += maxArray[i];
    }

    console.log(`${minSum} ${maxSum}`);

}