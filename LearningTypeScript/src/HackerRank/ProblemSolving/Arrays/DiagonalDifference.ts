export function diagonalDifference(arr: number[][]): number {

    let RightSum: number = 0;
    let LeftSum: number = 0;
    let lastIndex: number = arr.length - 1;

    for(let i = 0; i <= lastIndex; i++) {

        let j = lastIndex - i;

        RightSum += arr[i][i];
        LeftSum += arr[i][j];
    }

    return Math.abs(RightSum - LeftSum);
}