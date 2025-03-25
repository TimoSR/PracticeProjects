export class WrongFlock {

    private seagulls: number;
    
    public constructor(n: number) {
        this.seagulls = n;
    }

    public getSeagulls(): number {
        return this.seagulls;
    }

    public conjoin(other) {
        this.seagulls += other.seagulls;
        return this;
    }

    public breed(other) {
        this.seagulls = this.seagulls * other.seagulls;
        return this;
    }
}