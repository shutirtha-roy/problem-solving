N = int(input())

for i in range(N):
    X = int(input())
    adder = 0
    for j in range(1,X):
        if X % j == 0:
            adder += j
    if X == adder:
        print(X, "eh perfeito")
    else:
        print(X, "nao eh perfeito")