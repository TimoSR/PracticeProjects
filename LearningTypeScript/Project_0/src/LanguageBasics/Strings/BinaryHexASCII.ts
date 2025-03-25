export class BinaryHexASCII {
    public static charHexBinaryStuff(): void {
        const originalChar: string = 'A'; // Example character

        // 0x20 is hexadecimal = value 32
        const flippedChar: string = String.fromCharCode(originalChar.charCodeAt(0) ^ 0x20);

        console.log(`Original character: ${originalChar} ASCII: ${originalChar.charCodeAt(0)} Binary: ${originalChar.charCodeAt(0).toString(2)}`);
        console.log(`Character after flipping the sixth bit: ${flippedChar} ASCII: ${flippedChar.charCodeAt(0)} Binary: ${flippedChar.charCodeAt(0).toString(2)}`);

        const hello: string = "A b B C Hello World!";

        for (const character of hello) {
            console.log(`CHAR '${character}' ASCII Value ${character.charCodeAt(0)} Binary ${character.charCodeAt(0).toString(2)}`);
        }
    }
}