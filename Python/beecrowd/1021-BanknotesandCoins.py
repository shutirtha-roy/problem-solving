N = float(input())
coin = int(str(N).split('.')[1])

count_list_Notas = [0 for i in range(0, 6)]
count_list_Moeda = [0 for i in range(0, 6)]



count_list_Notas[0] = int(N / 100.00)
N = N - count_list_Notas[0] * 100
count_list_Notas[1] = int(N / 50.00)
N = N - count_list_Notas[1] * 50.00
count_list_Notas[2] = int(N / 20.00)
N = N - count_list_Notas[2] * 20.00
count_list_Notas[3] = int(N / 10.00)
N = N - count_list_Notas[3] * 10.00
count_list_Notas[4] = int(N / 5.00)
N = N - count_list_Notas[4] * 5.00
count_list_Notas[5] = int(N / 2.00)
N = N - count_list_Notas[5] * 2.00


count_list_Moeda[0] = int(N / 1.00)
N = N - count_list_Moeda[0]


count_list_Moeda[1] = int(coin / 50)
coin = coin - count_list_Moeda[1] * 50
count_list_Moeda[2] = int(coin / 25)
coin = coin - count_list_Moeda[2] * 25
count_list_Moeda[3] = int(coin / 10)
coin = coin - count_list_Moeda[3] * 10
count_list_Moeda[4] = int(coin / 5)
coin = coin - count_list_Moeda[4] * 5
count_list_Moeda[5] = int(coin / 1)
coin = coin - count_list_Moeda[5] * 1


print('NOTAS:')
print('{} nota(s) de R$ 100.00'.format(count_list_Notas[0]))
print('{} nota(s) de R$ 50.00'.format(count_list_Notas[1]))
print('{} nota(s) de R$ 20.00'.format(count_list_Notas[2]))
print('{} nota(s) de R$ 10.00'.format(count_list_Notas[3]))
print('{} nota(s) de R$ 5.00'.format(count_list_Notas[4]))
print('{} nota(s) de R$ 2.00'.format(count_list_Notas[5]))
print('MOEDAS:')
print('{} moeda(s) de R$ 1.00'.format(count_list_Moeda[0]))
print('{} moeda(s) de R$ 0.50'.format(count_list_Moeda[1]))
print('{} moeda(s) de R$ 0.25'.format(count_list_Moeda[2]))
print('{} moeda(s) de R$ 0.10'.format(count_list_Moeda[3]))
print('{} moeda(s) de R$ 0.05'.format(count_list_Moeda[4]))
print('{} moeda(s) de R$ 0.01'.format(count_list_Moeda[5]))