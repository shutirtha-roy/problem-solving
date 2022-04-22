import math
 
while(True):
 
    value = input()
 
    if len(value) == 1:
        if int(value) == 0:
            break
    else:
        value = value.split()
        A = int(value[0])
        B = int(value[1])
        C = int(value[2])
 
        size_of_land = ((A * B) / C) * 100
        print(int(math.sqrt(size_of_land)))