def is_prime(num):
    if num <= 1:
        return False
    for i in range(2, int(num**0.5) + 1):
        if num % i == 0:
            return False
    return True

def get_prime_average(numbers):
    prime_numbers = [num for num in numbers if is_prime(num)]
    if prime_numbers:
        return sum(prime_numbers) / len(prime_numbers)
    else:
        return None

def main():
    numbers = []
    for i in range(10):
        while True:
            try:
                number = int(input(f"Enter number {i+1}: "))
                numbers.append(number)
                break
            except ValueError:
                print("Invalid input. Please enter an integer.")

    average_prime = get_prime_average(numbers)
    
    if average_prime is not None:
        print(f"The average of the prime numbers in the collection is: {average_prime}")
    else:
        print("There are no prime numbers in the collection.")

main()
