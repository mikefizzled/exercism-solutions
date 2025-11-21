<?php

class PizzaPi
{
    private const SAUCE_PER_PIZZA = 125;
    
    public function calculateDoughRequirement(int $pizzas, int $persons) : int
    {
        return ($pizzas * (($persons * 20) + 200));
    }

    public function calculateSauceRequirement(int $pizzas, $sauceCanVolume) : int
    {
        return ceil($pizzas * self::SAUCE_PER_PIZZA / $sauceCanVolume);
    }

    public function calculateCheeseCubeCoverage(float $cheeseDimension, float $thickness, float $diameter) : int
    {
        $cubedCheese = $cheeseDimension ** 3;
        $areaPerPizza = ($thickness * pi() * $diameter);
        return floor($cubedCheese / $areaPerPizza);
    }

    public function calculateLeftOverSlices(int $leftoverPizzas, int $numberOfFriends) : int
    {
        $totalSlices = $leftoverPizzas * 8;
        return ($totalSlices % $numberOfFriends);
    }
}
