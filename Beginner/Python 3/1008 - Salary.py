# Declare Variables
NUMBER = int(input())       # Employer id number
hours_worked = int(input()) # Hours worked per month
hour_money = float(input()) # Money paid per hour

# Calculate salary
SALARY = hours_worked * hour_money

# Show result
print("NUMBER = {0}\nSALARY = U$ {1:.2f}".format(NUMBER, SALARY))
