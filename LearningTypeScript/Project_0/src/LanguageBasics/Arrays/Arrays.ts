export class Arrays {

    // Limiting array size
    private static array: number[] = new Array(6);
    // Initializing the array with zeros
    private static arrayFill: number[] = new Array(6).fill(0);

    public static printer(): void {

        console.log("Undefined Array")

        for (let value of this.array) {
            console.log(value);
        }

        console.log("Defined 0 Array")

        for (let valued of this.arrayFill) {
            console.log(valued);
        }
    }
}