def get_user_details():
    while True:
        name = input("Enter your name: ")
        if name.isalpha() or ' ' in name:
            break
        else:
            print("Invalid name. Please enter alphabetic characters only.")

    while True:
        age = input("Enter your age: ")
        if age.isdigit() and 0 < int(age) < 120:
            break
        else:
            print("Invalid age. Please enter a valid age between 1 and 119.")

    while True:
        dob = input("Enter your date of birth (YYYY-MM-DD): ")
        if len(dob) == 10 and dob[4] == '-' and dob[7] == '-':
            break
        else:
            print("Invalid date of birth. Please enter in the format YYYY-MM-DD.")

    while True:
        phone = input("Enter your phone number: ")
        if phone.isdigit() and len(phone) == 10:
            break
        else:
            print("Invalid phone number. Please enter a 10-digit phone number.")

    print("\n Your Details:")
    print(f"Name        : {name}")
    print(f"Age         : {age}")
    print(f"Date of Birth: {dob}")
    print(f"Phone Number: {phone}")

get_user_details()
