N = input()

number = N.split('.')
if number[1].startswith('0'):
    number[1] = number[1].strip("0")

print('{}.{}'.format(number[1], number[0]))