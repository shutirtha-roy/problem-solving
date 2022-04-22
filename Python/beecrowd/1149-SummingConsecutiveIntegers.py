values = input().split()

A = int(values[0])
N = int(values[1])

if N <= 0:
    for number in range(2, len(values), 1):
        if not int(values[number]) <= 0:
            N = int(values[number])
        
for i in range(A + 1, A + N, 1):
    A += i
print(A)