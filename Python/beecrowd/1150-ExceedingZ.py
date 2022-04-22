X = int(input())
Z = 0
while(True):
    Z = int(input())
    if Z > X:
        break

sum = 0
counter = 0
while(sum <= Z):
    counter += 1
    sum += X
    X += 1
print(counter)