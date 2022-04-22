S = 1
magic_counter = 2

for i in range(2, 38 + 1, 2):
    S += (i + 1)/magic_counter
    magic_counter *= 2
print('{:.2f}'.format(S))