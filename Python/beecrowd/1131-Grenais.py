inter_value = 0
gremio_value = 0
emphates = 0
counter = 0

while(True):
    inter, gremio  = input().split()
    
    print("Novo grenal (1-sim 2-nao)")
    possibility = int(input())
    counter += 1
    
    if inter > gremio:
        inter_value += 1
    elif inter < gremio:
        gremio_value += 1
    else:
        emphates += 1
    
    if possibility == 1:
        continue
    else:
        print("{} grenais".format(counter))
        print("Inter:{}".format(inter_value))
        print("Gremio:{}".format(gremio_value))
        print("Empates:{}".format(emphates))
        
        if inter > gremio:
            print("Inter venceu mais")
        elif inter < gremio:
            print("Gremio venceu mais")
        else:
            print("Não houve vencedor")
        break