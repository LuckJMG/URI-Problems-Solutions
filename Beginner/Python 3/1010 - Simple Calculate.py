# Declare Variables
product_1 = input().split()
product_2 = input().split()

# Calculate value to pay
total = float(product_1[1]) * float(product_1[2]) + float(product_2[1]) * float(product_2[2])

# Show result
print("VALOR A PAGAR: R$ {:.2f}".format(total))
