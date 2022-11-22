from re import X


number = []


while True:
    x=int(input())
    if x == 0 :
        break
    number.append(x)


name = input()
if name == 'Min':
    number.sort()
    print(number)
elif name == 'Max':
    number.sort(reverse=True)
    print(number)

    
    
