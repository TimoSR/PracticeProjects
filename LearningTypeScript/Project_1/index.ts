import {Counter, ICounter} from "./Counter";
import {CorrectFlock} from "./CorrectFlock";
import {WrongFlock} from "./WrongFlock";

const counter: ICounter = Counter();

counter.increment();

console.log(counter.getValue());

const flockA = new CorrectFlock(4);
const flockB = new CorrectFlock(2);
const flockC = new CorrectFlock(0);

const result =
    flockA
    .conjoin(flockC)
    .breed(flockB)
    .conjoin(flockA.breed(flockB));

console.log(result.seagulls);

const flockA1 = new WrongFlock(4);
const flockB1 = new WrongFlock(2);
const flockC1 = new WrongFlock(0);

const result1 =
    flockA1
    .conjoin(flockC1)
    .breed(flockB1)
    .conjoin(flockA1.breed(flockB1));

console.log(result1.getSeagulls());