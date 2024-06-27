num= int(input("Enter a number"))

x=2
while x < num:
    if num%x ==0:
        print("Not a Prime Number")
        break
    else:
        x= x+1
if x == num:
     print(num , " is a Prime Number")
