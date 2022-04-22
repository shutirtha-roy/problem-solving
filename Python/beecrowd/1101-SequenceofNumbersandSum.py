def passed_value(M, N):
    sum = 0
    if M > N:
        for i in range(N, M + 1, 1):
            print(i, end = ' ')
            sum += i
        print("Sum={}".format(sum))
    if M < N:
        for i in range(M, N + 1, 1):
            print(i, end = ' ')
            sum += i
        print("Sum={}".format(sum))
    if M == N:
        print(M, "Sum={}".format(8))

while(True):
    values = input().split()
    M = int(values[0])
    N = int(values[1])
    if M <= 0 or N <= 0:
        break
    passed_value(M, N)