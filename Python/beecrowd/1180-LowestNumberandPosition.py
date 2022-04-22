n = int(input())
x = list(map(int, input().split( )))

min_val = min(x)
min_idx = x.index(min_val)
    
print("Menor valor:", min_val)   

print("Posicao:", min_idx)