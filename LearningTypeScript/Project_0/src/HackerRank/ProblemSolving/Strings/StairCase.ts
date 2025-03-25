export function staircase(n: number): void {

    for(let i = 1; i <= n; i++) {

        let symbols: string = '#'.repeat(i);
        let spaces: string = ' '.repeat(n - i)
        console.log(spaces + symbols);

    }
}