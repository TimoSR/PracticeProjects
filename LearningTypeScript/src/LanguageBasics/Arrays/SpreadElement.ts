class SpreadElement {
    // Spread element ... in JS
    public static combineArrays(): void {
        const row0 = [1, 2, 3];
        const row1 = [4, 5, 6];
        const row2 = [7, 8, 9];

        const single = [...row0, ...row1, ...row2];

        for (let i = 0; i < single.length; i++) {
            process.stdout.write(`${single[i]}, `);
        }
    }
}