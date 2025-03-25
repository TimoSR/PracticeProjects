
// define the values we expect access
export interface ICounter {
    increment(): void;
    decrement(): void;
    getValue(): number;
}

export function Counter(input?: string): ICounter {

    const api = {
        increment,
        decrement,
        getValue
    };

    let count: number = 0;

    function increment() 
    {
        count++;
    }
    
    function decrement() 
    { 
        count--; 
    }
    
    function getValue() 
    { 
        return count; 
    }

    return api;
}