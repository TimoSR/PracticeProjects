export class WorkingWithStringTemplates {
    public static stringStuffReplace(): void {
        let template = "[A], [B]";

        console.log(`Original String: ${template}`);

        let replace = template
            .replace("[A]", "Hello")
            .replace("[B]", "World!");

        console.log(`Replace String: ${replace}`);
    }

    public static stringStuffInterpolation(): void {
        let hello = "Hello";
        let world = "World!";
        let interpolatedString = `${hello}, ${world}`;

        console.log(`Interpolated String: ${interpolatedString}`);
    }
}