function raindrops(number)
    local result = ""
    if number % 3 == 0 then
        result = result .. "Pling"
    end
    if number % 5 == 0 then
        result = result .. "Plang"
    end
    if number % 7 == 0 then
        result = result .. "Plong"
    end
    if result == "" then
        result = tostring(number)
    end
    return result
end

return raindrops
