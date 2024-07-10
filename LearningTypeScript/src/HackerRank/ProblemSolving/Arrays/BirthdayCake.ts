export function birthdayCakeCandles(candles: number[]): number {

    let maxHeight = Math.max(...candles);
    let maxCandleAmount = 0;

    for(let value of candles) {

        if (value === maxHeight) {
            maxCandleAmount++;
        }

    }

    return maxCandleAmount;
}