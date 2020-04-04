# Declare Variables
name = input()          # Seller's name
salary = float(input()) # Seller's salary
sales = float(input())  # Sale's total made by the seller in the month 

# Calculate salary with bonus
total = salary + (sales * .15)

# Show result
print("TOTAL = R$ {:.2f}".format(total))
