for i in range(1, 40, 1):
    print('-', end = '')    
print()
for i in range(1, 6, 1):
    for j in range(1, 40, 1):
        if j == 1 or j == 39:
            print('|', end = '')
        else:
            print(' ', end = '')
    print()
for i in range(1, 40, 1):
    print('-', end = '')    
print()