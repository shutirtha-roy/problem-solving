def magic_matrix(N):

  even_array = [3] * N
  odd_array = [3] * N

  if(N % 2 == 0):

    for i in range(1, N + 1):
      for j in range(1, int((N + 1)/ 2)):

        even_array[i - 1] = 1
        even_array[len(even_array) - i] = 2

        
      print(*even_array, sep='')
      even_array = [3] * N

  elif(N % 2 == 1):

    for i in range(1, N + 1):
      for j in range(1, int((N + 1)/ 2)):
        if(i != int(N/2 + 1)):
          odd_array[i - 1] = 1
          odd_array[len(odd_array) - i] = 2
        else:
          odd_array[int(N/2 + 1) - 1] = 2

        
      print(*odd_array, sep='')
      odd_array = [3] * N
  
  

if __name__ == '__main__':
  while(True):
    try:
      N = int(input())
      magic_matrix(N)
    except Exception:
      break