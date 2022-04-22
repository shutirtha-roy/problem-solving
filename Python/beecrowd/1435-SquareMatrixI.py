def square_matrix(N):
  for row in range(1, N + 1):
    string_row = ''
    for column in range(1, N + 1):
      row_complement = (N + 1 - row)
      col_complement = (N + 1 - column)

      if(row == min(row, column, row_complement, col_complement)):
        string_row += ' %3d' %(row)

      elif(column == min(row, column, row_complement, col_complement)):
        string_row += ' %3d' %(column)

      elif(row_complement == min(row, column, row_complement, col_complement)):
        string_row += ' %3d' %(row_complement)

      elif(col_complement == min(row, column, row_complement, col_complement)):
        string_row += ' %3d' %(col_complement)

    print(string_row.rstrip()[1:])
  print()  
  
  

if __name__ == '__main__':
  while(True):
    N = int(input())
    if(N == 0):
      break
    else:
     square_matrix(N)