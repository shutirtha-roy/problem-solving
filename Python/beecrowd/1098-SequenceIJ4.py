I = 0
J = 1
while(I <= 2):
    for i in range(0, 3, 1):
        I = round(I, 1)
        J = round(J, 1)
        if I == int(I):
            print('I={:.0f} J={:.0f}'.format(I, J))
        else:
            print('I={} J={}'.format(I, J))
        J += 1
    I += 0.2
    J = 1
    J += I