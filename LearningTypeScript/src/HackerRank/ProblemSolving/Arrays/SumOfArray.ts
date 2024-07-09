export function simpleArraySum(ar: number[]): number {

    let sum: number = 0;

    for(let value of ar) {
        sum += value;
    }

    return sum;
}