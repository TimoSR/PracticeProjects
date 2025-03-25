export class CorrectFlock {

    readonly seagulls: number;

    public constructor(n: number) {
        this.seagulls = n;
    }

    public conjoin(other: CorrectFlock): CorrectFlock {
        return new CorrectFlock(this.seagulls + other.seagulls);
    }

    public breed(other: CorrectFlock): CorrectFlock {
        return new CorrectFlock(this.seagulls * other.seagulls);
    }
}