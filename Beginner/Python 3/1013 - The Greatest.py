# Declare Variables
numbers = input().split(' ')
a = int(numbers[0])
b = int(numbers[1])
c = int(numbers[2])

# Calculate
preGreater = (a + b + abs(a - b)) / 2
greater = (preGreater + c + abs(preGreater - c)) / 2

# Show result
print("{} eh o maior".format(int(greater)))
