clang: Apple Clang is the default compiler for macOS, provided via Xcode or the Xcode Command Line Tools. It

mach-O: Mach-O (Mach object) is the native binary file format for executables, libraries, and object code on macOS and iOS. It replaced the older a.out format and is used by the operating system loader to manage and run apps, using extensions like .o, .dylib, and .kext

Structure: Comprised of a header, load commands, and segments (containing sections like __TEXT for code and __DATA for data).
Purpose: Encapsulates all information needed for the dynamic linker (dyld) to prepare a program for execution.
Compatibility: Supports "fat binaries," allowing a single file to contain code for multiple architectures (e.g., Intel x86-64 and Apple Silicon ARM64).
Security: Enables Address Space Layout Randomization (ASLR) to secure against exploits.


Use otool to disassemble, hexdump or xxd to view raw bytes, and otool -l/-hv to inspect the Mach-O structure. On macOS, your compiled files are Mach-O binaries, and the actual instructions/data live inside sections grouped into segments.

file add_exit
xcrun otool-classic -hv add_exit
xcrun otool-classic -l add_exit
xcrun otool-classic -tV add_exit
hexdump -C add_exit | head -n 40

What they give you:

file add_exit tells you what kind of binary it is.
xcrun otool-classic -hv add_exit shows the Mach-O header.
xcrun otool-classic -l add_exit shows the load commands.
xcrun otool-classic -tV add_exit disassembles the __TEXT,__text code section.
hexdump -C add_exit shows the raw bytes. hexdump is a byte-level formatter for files/stdin.