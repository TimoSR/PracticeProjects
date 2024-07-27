import {Arrays} from "./LanguageBasics/Arrays/Arrays";
import {plusMinus} from "./HackerRank/ProblemSolving/Arrays/PlusMinus";
import {staircase} from "./HackerRank/ProblemSolving/Strings/StairCase";
import {minMaxSum} from "./HackerRank/ProblemSolving/Arrays/MinMaxSum";
import {BinaryHexASCII} from "./LanguageBasics/Strings/BinaryHexASCII";
import {LongRawStringLiterals} from "./LanguageBasics/Strings/LongRawStringLiterals";
import {FilteringAndJoiningStringArrays} from "./LanguageBasics/Strings/FilteringAndJoiningStringArrays";
import {TimeConversion} from "./HackerRank/ProblemSolving/Date&Time/TimeConversion";

function main() {

    let Arrays1 = new Arrays();
    let array: number[] = [0, 1, -1, 0, 1];
    let array2: number[] = [7, 69, 2, 221, 8974];

    Arrays.printer();
    plusMinus(array);
    staircase(4);
    minMaxSum(array2);
    BinaryHexASCII.charHexBinaryStuff();
    FilteringAndJoiningStringArrays.filterArray();
    console.log(TimeConversion.timeConversion("S"))
}

// Run the main function
main();