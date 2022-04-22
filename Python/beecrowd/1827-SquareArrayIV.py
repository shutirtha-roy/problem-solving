def magic_matrix (N:int):

  for i in range(N):
    for j in range(N):
      if(i == int(N / 2) and j == int(N / 2)):
        print('4', end = '')
      elif( int(N / 3) <= i <= (N - 1) - int(N / 3)  ) \
      and ( int(N / 3) <= j <= (N - 1) - int(N / 3)  ):
        print('1', end = '')
      elif(i == j):
        print('2', end = '')
      elif(j + i == N - 1):
        print('3', end = '')
      else:
        print('0', end = '')
    print()
  print()



if __name__ == '__main__':
  while(True):
    try:
      N = int(input())
      magic_matrix(N)
    except Exception:
      break