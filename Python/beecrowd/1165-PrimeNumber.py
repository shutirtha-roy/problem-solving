N = int(input())

for i in range(N):
    value = int(input())
    counter = 0
    for i in range(1, value + 1):
        if value % i == 0:
            counter += 1
    if counter == 2:
        print(value, "eh primo")
    else:
        print(value, "nao eh primo")