def magic_matrix (N:int, V:list):

  max_num = max(V)

  if (max_num < 10):
    return 1
  elif (10 < max_num < 20):
    return 2
  elif (max_num >= 20):
    return 3



if __name__ == '__main__':
  while(True):
    try:
      N = int(input())
      V = [int(i) for i in input().split()] 
      print(magic_matrix(N, V))
    except Exception:
      break