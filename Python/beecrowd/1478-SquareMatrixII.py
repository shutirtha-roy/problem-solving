def square_matrix(N):
  for row in range(1, N + 1):
    string_row = ''
    for column in range(1, N + 1):
      string_row += ' %3d' %(abs(row - column) + 1)
    
    print(string_row.rstrip()[1:])
  print()  
  
  

if __name__ == '__main__':
  while(True):
    N = int(input())
    if(N == 0):
      break
    else:
     square_matrix(N)