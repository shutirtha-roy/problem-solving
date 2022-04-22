N = input()

dates = N.split('/')

print('{}/{}/{}'.format(dates[1], dates[0], dates[2]))
print('{}/{}/{}'.format(dates[2], dates[1], dates[0]))
print('{}-{}-{}'.format(dates[0], dates[1], dates[2]))