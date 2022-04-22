N = int(input())
value = "Ho"

for i in range(N):
    if i == N - 1:
        print(value, end = '')
    else:
        print(value, end = ' ')
print('!')