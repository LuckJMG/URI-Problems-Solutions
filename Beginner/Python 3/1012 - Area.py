# Declare Variables
numbers = input().split(' ')
A = float(numbers[0])
B = float(numbers[1])
C = float(numbers[2])
pi = 3.14159

# Calculate Areas
triangle = (A * C) / 2
circle = C * C * pi
trapezium = C * ((A + B) / 2)
square = B * B
rectangle = A * B

# Show result
print("TRIANGULO: {:.3f}".format(triangle))
print("CIRCULO: {:.3f}".format(circle))
print("TRAPEZIO: {:.3f}".format(trapezium))
print("QUADRADO: {:.3f}".format(square))
print("RETANGULO: {:.3f}".format(rectangle))
