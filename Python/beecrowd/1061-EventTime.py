day_input_One = input()
time_input_One = input()

day_input_Two = input()
time_input_Two = input()

day_One = int(day_input_One.split(' ')[1])
time_hour_One = int(time_input_One.split(':')[0])
time_min_One = int(time_input_One.split(':')[1])
time_sec_One = int(time_input_One.split(':')[2])

day_Two = int(day_input_Two.split(' ')[1])
time_hour_Two = int(time_input_Two.split(':')[0])
time_min_Two = int(time_input_Two.split(':')[1])
time_sec_Two = int(time_input_Two.split(':')[2])

total_initial_seconds = day_One * 24 * 60 * 60 + time_hour_One * 60 * 60 + time_min_One * 60 + time_sec_One
total_final_seconds = day_Two * 24 * 60 * 60 + time_hour_Two * 60 * 60 + time_min_Two * 60 + time_sec_Two

remaining = total_final_seconds - total_initial_seconds

day = int(remaining / (24 * 60 * 60))
remaining_sec = int(remaining % (24 * 60 * 60))
hour = int(remaining_sec / (60 * 60))
remaining_sec = int(remaining % (60 * 60))
minuite = int(remaining_sec / (60)) 
remaining_sec = int(remaining % (60))
print('{} dia(s)\n{} hora(s)\n{} minuto(s)\n{} segundo(s)'.format(day, hour, minuite, remaining_sec))