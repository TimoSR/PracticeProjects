import {Arrays} from "./LanguageBasics/Arrays";
import {plusMinus} from "./HackerRank/ProblemSolving/Arrays/PlusMinus";
import {staircase} from "./HackerRank/ProblemSolving/Strings/StairCase";

function main() {

    let Arrays1 = new Arrays();
    let array: number[] = [0, 1, -1, 0, 1];

    Arrays.printer();
    plusMinus(array);
    staircase(4);
}

// Run the main function
main();