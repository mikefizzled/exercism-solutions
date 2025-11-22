section .text
EXPECTED_MINUTES equ 40
PREP_TIME_PER_LAYER equ 2

global expected_minutes_in_oven
expected_minutes_in_oven:
    mov rax, EXPECTED_MINUTES
    ret

global remaining_minutes_in_oven
remaining_minutes_in_oven:
    mov rax, EXPECTED_MINUTES
    sub rax, rdi
    ret

global preparation_time_in_minutes
preparation_time_in_minutes:
    mov rax, PREP_TIME_PER_LAYER
    imul rax, rdi
    ret

global elapsed_time_in_minutes
elapsed_time_in_minutes:
    mov rax, PREP_TIME_PER_LAYER
    imul rax, rdi
    add rax, rsi
    ret

%ifidn __OUTPUT_FORMAT__,elf64
section .note.GNU-stack noalloc noexec nowrite progbits
%endif
