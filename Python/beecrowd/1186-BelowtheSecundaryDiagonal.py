operation = input()
useless_value = ""
addition = 0
total_columns = 12
counter = 0

for i in range(total_columns):

    for j in range(0, total_columns):
        
        if 12 - i <= j < 12:
            value = float(input())
            addition += value
            counter += 1
        else:
            useless_value = input()
            
if operation == 'S':
    print("{:.1f}".format(addition))
elif operation == 'M':
    print("{:.1f}".format(addition / counter))