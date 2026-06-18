Running ARM64 assembly source

```bash
clang add_exit.s -o add_exit
./add_exit
echo $?

clang run_raw.c -o run_raw
```

Running C

### Run the assembly example

```bash
clang add_exit.s -o add_exit
./add_exit
echo $?
```

### Build the raw-bytes example

```bash
clang run_raw.c -o run_raw
```