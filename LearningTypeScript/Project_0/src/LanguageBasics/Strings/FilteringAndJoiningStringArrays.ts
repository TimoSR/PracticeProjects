export class FilteringAndJoiningStringArrays {
    public static filterArray(): void {
        const items = ["apple", "banana", "cherry", "date", "fig", "grape"];
        const searchTerm = "a";

        const includeFilteredItems = items.filter(item => item.includes(searchTerm));

        // Filter items to exclude those that include the searchTerm
        const excludeFilteredItems = items.filter(item => !item.includes(searchTerm));

        console.log(`Original Array: ${items.join(", ")}`);
        console.log(`Include Filtered Array: ${includeFilteredItems.join(", ")}`);
        console.log(`Exclude Filtered Array: ${excludeFilteredItems.join(", ")}`);
    }
}