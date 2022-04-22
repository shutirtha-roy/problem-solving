line_no = int(input())
operation = input()
useless_value = ""
addition = 0
total_columns = 12

for i in range(total_columns):
    for j in range(total_columns):
        if j == line_no:
            value = float(input())
            addition += value
        else:
            useless_value = input()

if operation == 'S':
    print("{:.1f}".format(addition))
elif operation == 'M':
    print("{:.1f}".format(addition / total_columns))