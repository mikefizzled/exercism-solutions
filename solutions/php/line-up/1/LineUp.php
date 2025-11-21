<?php

/*
 * By adding type hints and enabling strict type checking, code can become
 * easier to read, self-documenting and reduce the number of potential bugs.
 * By default, type declarations are non-strict, which means they will attempt
 * to change the original type to match the type specified by the
 * type-declaration.
 *
 * In other words, if you pass a string to a function requiring a float,
 * it will attempt to convert the string value to a float.
 *
 * To enable strict mode, a single declare directive must be placed at the top
 * of the file.
 * This means that the strictness of typing is configured on a per-file basis.
 * This directive not only affects the type declarations of parameters, but also
 * a function's return type.
 *
 * For more info review the Concept on strict type checking in the PHP track
 * <link>.
 *
 * To disable strict typing, comment out the directive below.
 */

declare(strict_types=1);

function format(string $name, int $number): string
{
    $ordinal = "";
    $special_number = $number % 100;
    
    if($special_number == 11 || $special_number == 12 || $special_number == 13){
        $ordinal = "th";
    }
    else{
        $remainder = $number % 10;
        switch($remainder){
            case(1):
                $ordinal = "st";
                break;
            case(2):
                $ordinal = "nd";
                break;
            case(3):
                $ordinal = "rd";
                break;
            default:
                $ordinal = "th";
                break;
        }
    }
    return "{$name}, you are the {$number}{$ordinal} customer we serve today. Thank you!";
}
