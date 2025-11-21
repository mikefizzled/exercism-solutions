<?php

class LuckyNumbers
{
    public function sumUp(array $digitsOfNumber1, array $digitsOfNumber2): int
    {
        (int) $num1 = implode($digitsOfNumber1);
        (int) $num2 = implode($digitsOfNumber2);
        return $num1 + $num2;
    }

    public function isPalindrome(int $number): bool
    {
        return (string) $number == strrev((string) $number);
    }

    public function validate(string $input): string
    {
        if($input == '')
            return 'Required field';
        else if((int) $input <= 0)
            return 'Must be a whole number larger than 0';
        else
            return '';
    }
}
