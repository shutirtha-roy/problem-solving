value = int(input())

first_num = 0
second_num = 1
temp_num = 0
if value == 1:
    print(first_num)
elif value == 2:
    print(f'{first_num} {second_num}')
else:
    print(f'{first_num} {second_num}', end = ' ')
    for i in range(3, value + 1, 1):
        temp_num = second_num
        second_num = second_num + first_num
        first_num = temp_num
        if i != value:
            print(second_num, end = ' ')
        else:
            print(second_num)