counter = 1
temp_counter = 0
average = 0
temporary_X = 0
while(True):
    X = float(input())
    
    if X == 2:
        break
    if X == 1:
        counter = 1
        temp_counter = 1
        continue
    if X < 0 or X > 10:
        print('nota invalida')
        continue
    if counter == 2:
        temp_counter = counter
        counter = 1
        average = (X + temporary_X) / 2
        print("media = {:.2f}".format(average))
        print("novo calculo (1-sim 2-nao)")
        continue
    if temp_counter == 2 and (X < 1 or X > 2):
        print("novo calculo (1-sim 2-nao)")
        continue
        
    counter += 1
    temporary_X = X