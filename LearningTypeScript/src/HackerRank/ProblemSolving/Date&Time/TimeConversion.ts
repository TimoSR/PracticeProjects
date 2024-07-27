export class TimeConversion {

    public static timeConversion(s: string): string {
        // Extract the period (AM/PM)
        const period = s.slice(-2);
        // Extract the hour part
        let hour = parseInt(s.slice(0, 2), 10);
        // Extract the minutes and seconds part
        const minutesSeconds = s.slice(2, -2);

        if (period === "AM") {
            // Convert 12 AM to 00
            if (hour === 12) {
                hour = 0;
            }
        } else {
            // Convert PM times except for 12 PM
            if (hour !== 12) {
                hour += 12;
            }
        }

        // Ensure hour is always two digits
        const hourString = hour.toString().padStart(2, "0");

        return `${hourString}${minutesSeconds}`;
    }

}