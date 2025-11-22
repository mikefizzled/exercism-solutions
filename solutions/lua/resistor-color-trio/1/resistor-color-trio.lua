local codes = {
    black = 0,
    brown = 1,
    red = 2,
    orange = 3,
    yellow = 4,
    green = 5,
    blue = 6,
    violet = 7,
    grey = 8,
    white = 9
}

return {
  decode = function(c1, c2, c3)
    local ohms_value = (codes[c1] * 10 + codes[c2]) * (10 ^ codes[c3])
    local units

    if ohms_value < 1000 then
      units = 'ohms'
    elseif ohms_value < 1000000 then
      ohms_value = ohms_value / 1000
      units = 'kiloohms'
    elseif ohms_value < 1000000000 then
      ohms_value = ohms_value / 1000000
      units = 'megaohms'
    else
      ohms_value = ohms_value / 1000000000
      units = 'gigaohms'
    end
    return ohms_value, units
  end
}