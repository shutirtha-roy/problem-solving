N = int(input())
adder = 4
counter = 1

for i in range(0, N, 1):
    for j in range(1, 4, 1):
        print(counter, end = ' ')
        counter += 1
    counter += 1
    print("PUM")