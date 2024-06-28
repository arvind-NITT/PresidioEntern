def luhn_check(card_number):
    card_number = card_number.replace(" ", "")
    total = 0
    reverse_digits = card_number[::-1]

    for i, digit in enumerate(reverse_digits):
        n = int(digit)
        if i % 2 == 1:
            n *= 2
            if n > 9:
                n -= 9
        total += n

    return total % 10 == 0

def main():
    card_number = input("Enter the credit card number: ").strip()
    if luhn_check(card_number):
        print("The credit card number is valid.")
    else:
        print("The credit card number is invalid.")

if __name__ == "__main__":
    main()
