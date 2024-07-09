export function compareTriplets(a: number[], b: number[]): number[] {

    let Alice: number = 0;
    let Bob: number = 0;
    let AmountOfScores = a.length;

    for(let i = 0; i < AmountOfScores; i++) {

        if(a[i] > b[i]) {
            Alice++;
        }
        else if (a[i] < b[i]) {
            Bob++;
        }

    }

    return [Alice, Bob];
}