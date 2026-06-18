It helps you understand the gap between source and CPU

Source code is just text.
Disassembly shows the actual decoded instructions inside the executable.

clang add_exit.s -o add_exit
xcrun otool-classic -tV add_exit > add_exit.disasm
code add_exit.s add_exit.disasm