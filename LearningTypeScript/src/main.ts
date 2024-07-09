import {Arrays} from "./LanguageBasics/Arrays";
import {plusMinus} from "./HackerRank/ProblemSolving/Arrays/PlusMinus";
import {staircase} from "./HackerRank/ProblemSolving/Strings/StairCase";
import {minMaxSum} from "./HackerRank/ProblemSolving/Arrays/MinMaxSum";

function main() {

    let Arrays1 = new Arrays();
    let array: number[] = [0, 1, -1, 0, 1];
    let array2: number[] = [7, 69, 2, 221, 8974];

    Arrays.printer();
    plusMinus(array);
    staircase(4);
    minMaxSum(array2);
}

// Run the main function
main();