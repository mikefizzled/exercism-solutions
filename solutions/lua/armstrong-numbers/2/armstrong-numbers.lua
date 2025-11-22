local ArmstrongNumbers = {}

function ArmstrongNumbers.is_armstrong_number(number)
  local arm_string = tostring(number)
  local length = #arm_string
  local sum = 0
  for i = 1, length do
    sum = sum + tonumber(string.sub(arm_string, i, i)) ^ length
  end
  return number == sum
end

return ArmstrongNumbers
