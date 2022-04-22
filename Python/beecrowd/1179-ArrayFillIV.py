par = []
impar = []
new_par = []

par_counter = 0
impar_counter = 0

temp_par = 0
temp_counter = 0

for i in range(15):
    
    value = int(input())
    
    
    if value % 2 == 0:
        
        par.append(value)
        par_counter += 1
        
    else:
        
        impar.append(value)
        impar_counter += 1
        
        
    if par_counter == 5:
        
        for i, j in enumerate(par):
            print("par[{}] = {}".format(i,j))
        
        temp_par = par_counter
        par_counter = 0
        par = []
        
        
    if impar_counter == 5:
        
        for i, j in enumerate(impar):
            print("impar[{}] = {}".format(i,j))
        
        temp_counter = impar_counter
        impar_counter = 0
        impar = []

if len(impar) > 0:        

    if impar[0] % 2 != 0:

        if len(impar) > 0:
            for i, j in enumerate(impar):
                    print("impar[{}] = {}".format(i,j))

        if len(par) > 0:
            for i, j in enumerate(par):
                    print("par[{}] = {}".format(i,j))
            
elif len(par) > 0:
    
    for i, j in enumerate(par):
                    print("par[{}] = {}".format(i,j))
            
            
if len(par) > 0:
            
    if par[0] % 2 != 0:    

        if len(par) > 0:
            for i, j in enumerate(par):
                    print("par[{}] = {}".format(i,j))

        if len(impar) > 0:        
            for i, j in enumerate(impar):
                    print("impar[{}] = {}".format(i,j))  
                    
elif len(impar) > 0:
    for i, j in enumerate(impar):
                    print("impar[{}] = {}".format(i,j))  