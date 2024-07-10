
function replaceCommasWithDots(input: string): string {

    /*
    Common Regular Expression Flags:
    - g: global - find all matches rather than stopping after the first match
    - i: case-insensitive - make the match case-insensitive
    - m: multiline - treat the input string as multiple lines
    - s: dotall - allow . to match newline characters
    - u: unicode - treat pattern as a sequence of unicode code points
    - y: sticky - matches only from the index indicated by the lastIndex property of this regular expression in the target string
    */

    return input.replace(/,/g, '.');
}

function replaceCommasWithDotsSplit(input: string): string {
    return input.split(',').join('.');
}
