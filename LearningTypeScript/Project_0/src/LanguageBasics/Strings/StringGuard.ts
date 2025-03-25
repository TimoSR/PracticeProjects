export class StringGuard {
    public sayHello(inputString: string): void {
        // Guard clause: Check if inputString is falsy (false, 0, empty string, null, undefined, or NaN)
        if (!inputString) {
            return;
        }

        console.log(inputString);
    }
}