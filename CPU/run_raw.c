#include <stdint.h>
#include <stdio.h>
#include <string.h>
#include <sys/mman.h>
#include <unistd.h>

typedef int (*fn_t)(void);

int main(void) {
    static const uint8_t code[] = {
        0x40, 0x00, 0x80, 0x52, // mov w0, #2
        0x61, 0x00, 0x80, 0x52, // mov w1, #3
        0x00, 0x00, 0x01, 0x0B, // add w0, w0, w1
        0xC0, 0x03, 0x5F, 0xD6  // ret
    };

    const size_t page_size = (size_t)sysconf(_SC_PAGESIZE);

    void *mem = mmap(
        NULL,
        page_size,
        PROT_READ | PROT_WRITE,
        MAP_PRIVATE | MAP_ANON,
        -1,
        0
    );

    if (mem == MAP_FAILED) {
        perror("mmap");
        return 1;
    }

    memcpy(mem, code, sizeof(code));

    if (mprotect(mem, page_size, PROT_READ | PROT_EXEC) != 0) {
        perror("mprotect");
        munmap(mem, page_size);
        return 1;
    }

    fn_t fn = (fn_t)mem;
    int result = fn();

    printf("%d\n", result);

    if (munmap(mem, page_size) != 0) {
        perror("munmap");
        return 1;
    }

    return 0;
}