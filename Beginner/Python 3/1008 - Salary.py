# Declare Variables
number = int(input())       # Employer id number
hours_worked = int(input()) # Hours worked per month
hour_money = float(input()) # Money paid per hour

# Calculate salary
salary = hours_worked * hour_money

# Show result
print("NUMBER = {0}\nSALARY = U$ {1:.2f}".format(number, salary))
