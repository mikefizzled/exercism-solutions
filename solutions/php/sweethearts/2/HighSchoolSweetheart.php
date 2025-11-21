<?php

class HighSchoolSweetheart
{
    public function firstLetter(string $name): string
    {
        return substr(trim($name), 0, 1);
    }

    public function initial(string $name): string
    {
        $letter = strtoupper($this->firstLetter($name));
        return $letter.".";
    }

    public function initials(string $name): string
    {
        $words = explode(" ", $name);
        $name = $this->initial($words[0])." ".$this->initial($words[1]);  
        return $name;
    }

    public function pair(string $sweetheart_a, string $sweetheart_b): string
    {
        $a = $this->initials($sweetheart_a);
        $b = $this->initials($sweetheart_b);
        return <<<END
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     $a  +  $b     **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
END;
    }
}
