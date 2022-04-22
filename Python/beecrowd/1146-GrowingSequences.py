while(True):
    X = int(input())
    if X == 0:
        break
    else:
        for number in range(1, X + 1, 1):
            if number != X:
                print(number, end = ' ')
            else:
                print(number)