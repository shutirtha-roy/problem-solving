tax = float(input())

if 0.00 < tax <= 2000.00:
    print('Isento')
elif 2000.01 < tax <= 3000.00:
    print('R$ {:.2f}'.format((tax - 2000) * 0.08))
elif 3000.00 < tax <= 4500.00:
    print('R$ {:.2f}'.format(1000 * 0.08 + (tax - 3000) * 0.18))
elif tax >=  4500.00:
    print('R$ {:.2f}'.format(1000 * 0.08 + (1500) * 0.18 + (tax - 4500) * 0.28))