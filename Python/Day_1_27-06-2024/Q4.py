def get_user_details():
    name = input("Enter your name: ")
    age = input("Enter your age: ")
    dob = input("Enter your date of birth (YYYY-MM-DD): ")
    phone = input("Enter your phone number: ")
   
    print("\Your Details:")
    print("-----------------------")
    print(f"Name          : {name}")
    print(f"Age           : {age}")
    print(f"Date of Birth : {dob}")
    print(f"Phone Number  : {phone}")
    print("-----------------------")
get_user_details()
