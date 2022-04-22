X = int(input())
Y = int(input())
A , B = 0, 0

if Y > X:
    A = X
    B = Y
else:
    A = Y
    B = X

for number in range(A + 1, B, 1):
    if number % 5 == 2:
        print(number)
    elif number % 5 == 3:
        print(number)