line_no = int(input())
operation = input()
total_columns = 12
addition = 0
useless_value = ""

for i in range(total_columns * total_columns):
    if i >= (line_no * 11 + line_no) and i <= (line_no * 11 + line_no + 11):
        value = int(input())
        addition += value
    else:
        useless_value = input()

if operation == 'S':
    print("{:.1f}".format(addition))
elif operation == 'M':
    print("{:.1f}".format(addition / total_columns))