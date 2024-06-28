def is_prime(num):
    if num <= 1:
        return False
    for i in range(2, int(num**0.5) + 1):
        if num % i == 0:
            return False
    return True

def find_primes(num):
    i=2
    lst=[]
    while i <= num :
        if is_prime(i):
            lst.append(i)
        i+=1
    print(lst)


find_primes(37)
