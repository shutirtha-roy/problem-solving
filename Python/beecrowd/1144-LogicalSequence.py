N = int(input())
if N < 9999:
    for num in range(1, N + 1, 1):
        print('{} {} {}'.format(num ** 1, num ** 2, num ** 3))
        print('{} {} {}'.format(num ** 1, num ** 2 + 1, num ** 3 + 1))
else:
    for i in range(1, N + 1, 1):
        print(i)