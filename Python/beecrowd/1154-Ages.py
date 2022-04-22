sum = 0
counter = 0
average = 0
while(True):
    num = int(input())
    if num < 0:
        break
    
    sum += num
    counter += 1
    
average = sum / counter
print('{:.2f}'.format(average))