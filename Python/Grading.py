grade = int(input())

if grade != -1:
    if  80 < grade < 100:
        print('A')
    elif 70 < grade  < 80:
        print('B')
    elif 60 < grade < 70:
        print('C')
    elif 50 < grade < 60:
        print('D')
    elif grade <= 49:
        print('F')
        
        
