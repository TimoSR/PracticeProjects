export function PlusMinus(arr: number[]): void {

    let positive: number = 0;
    let negative: number = 0;
    let zero: number = 0;

    for(let value of arr) {

        if(value > 0) {
            positive++;
        }
        else if(value < 0) {
            negative++;
        }
        else {
            zero++;
        }

    }

    let ratios: number[] = [positive/arr.length,
                            negative/arr.length,
                            zero/arr.length];

    for(let value of ratios) {

        console.log(`${value.toFixed(6)}`);

    }
}