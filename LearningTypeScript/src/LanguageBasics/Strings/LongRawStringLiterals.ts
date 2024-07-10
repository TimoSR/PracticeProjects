export class LongRawStringLiterals {
    public static longString(): void {
        const longitude: number = 5;
        const latitude: number = 4;

        const longMessage: string = `
            This is a long message.
            It has several lines.
                Some are indented
                        more than others.
            Some should start at the first column.
            Some have "quoted text" in them.
        `;

        const location: string = `You are at ${longitude}, ${latitude}`;

        console.log();
        console.log(longMessage);
        console.log(location);
    }
}
