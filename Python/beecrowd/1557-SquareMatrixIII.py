import math

def magic_matrix(N):

  value = 1
  max_digit_counter = int(math.pow(2, (N - 1) + (N - 1)))
  no_of_max_digits = countDigit(max_digit_counter)

  for i in range(0, N):
    for j in range(0, N):
      value = int(math.pow(2, (j) + (i)))
      if(j == 0):
        print('{:{}d}'.format(value, no_of_max_digits), end='')
      else:
        print(' {:{}d}'.format(value, no_of_max_digits), end='')

    print()
  print()

  
def countDigit(n):
    count = 0
    while n != 0:
        n //= 10
        count += 1
    return count

if __name__ == '__main__':
  while(True):
    N = int(input())
    if(N == 0):
      break
    else:
     magic_matrix(N)