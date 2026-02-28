interface Hello {
    AnotherFunction(): void;
    CoolFunction(): number;
}

interface AnotherHello {}

type HahaTypes = {
    AnotherFunction(): void;
    CoolFunction(): number;
}

export function SomeFunction(): Hello & AnotherHello {

    const api = {
        AnotherFunction,
        CoolFunction
    }

    function AnotherFunction(): void {console.log("Hello World")}
    function CoolFunction(): number {return 0}

    return api;
}