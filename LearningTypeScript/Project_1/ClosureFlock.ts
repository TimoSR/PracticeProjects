
export interface IClosureFlock {
    getSeagulls(): number;
}

export function createFlock(seagulls: number) {

    const getSeagulls = () => seagulls;

    const conjoin = (other: ReturnType<typeof createFlock>) =>
        createFlock(seagulls + other.getSeagulls());

    return {

        getSeagulls,
        conjoin,
        breed: (other: ReturnType<typeof createFlock>) =>
            createFlock(seagulls * other.getSeagulls()),
    };
}

function createVerboseFLock(seagulls: number) {

    const api = {

    }

    const getSeagulls = () : number => seagulls;

}

