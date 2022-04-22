N = int(input())

for i in range(1, N + 1):
    value = input().split(' ')
    X = int(value[0])
    Y = int(value[1])
    
    if X % 2 == 0:
        X += 1
        
    sum = X    
    
    for i in range(2 , Y + 1, 1):
        sum += (X + 2)
        X += 2
    print(sum)