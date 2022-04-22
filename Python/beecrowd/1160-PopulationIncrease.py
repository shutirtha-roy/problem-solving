import math
T = int(input())
for i in range(T):
    PA, PB, G1, G2 = input().split(' ')
    PA = int(PA)
    PB = int(PB)
    G1 = float(G1) * 0.01
    G2 = float(G2) * 0.01
    count = 0
    while True:
        if PA > PB:
            break
        PA = PA + math.floor(PA * G1)
        PB = PB + math.floor(PB * G2)
        count += 1
        if count > 100:
            break
        
    if count > 100:
        print("Mais de 1 seculo.")
    else:
        print(count, "anos.")