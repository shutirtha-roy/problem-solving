initial_hour, initial_minute, final_hour, final_minute = input().split(" ")
initial_hour = int(initial_hour)
initial_minute = int(initial_minute)
final_hour = int(final_hour)
final_minute = int(final_minute)


if final_hour > initial_hour:

    minutes_in = initial_hour * 60 + initial_minute
    minutes_fi = final_hour * 60 + final_minute
    lasted = minutes_fi - minutes_in
    lasted_hour = int(lasted / 60)
    lasted_min = lasted % 60
    print('O JOGO DUROU {} HORA(S) E {} MINUTO(S)'.format(lasted_hour, lasted_min))
        
elif final_hour == initial_hour:
    
    if final_minute == initial_minute:
        print('O JOGO DUROU {} HORA(S) E {} MINUTO(S)'.format(24, 0))
    elif final_minute < initial_minute:
        lasted_min = (60 - initial_minute) + final_minute
        print('O JOGO DUROU {} HORA(S) E {} MINUTO(S)'.format(23, lasted_min))
    else:
        print('O JOGO DUROU {} HORA(S) E {} MINUTO(S)'.format(0, final_minute - initial_minute))
        
else:
    
    if final_minute < initial_minute:
        lasted = (24 - initial_hour + final_hour) * 60 - (initial_minute - final_minute)
        lasted_hour = int(lasted / 60)
        lasted_min = lasted % 60
        print('O JOGO DUROU {} HORA(S) E {} MINUTO(S)'.format(lasted_hour, lasted_min))
    else:
        lasted = (24 - initial_hour + final_hour) * 60 + (final_minute - initial_minute)
        lasted_hour = int(lasted / 60)
        lasted_min = lasted % 60
        print('O JOGO DUROU {} HORA(S) E {} MINUTO(S)'.format(lasted_hour, lasted_min))