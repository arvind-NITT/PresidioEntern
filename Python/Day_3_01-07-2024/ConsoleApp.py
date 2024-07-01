import datetime
import re
import pandas as pd
from fpdf import FPDF

def validate_name(name):
    return bool(re.match(r'^[A-Za-z\s]+$', name))

def validate_dob(dob):
    try:
        datetime.datetime.strptime(dob, '%Y-%m-%d')
        return True
    except ValueError:
        return False

def validate_phone(phone):
    return bool(re.match(r'^\d{10}$', phone))

def validate_email(email):
    return bool(re.match(r'^[\w\.-]+@[\w\.-]+\.\w+$', email))

def calculate_age(dob):
    birth_date = datetime.datetime.strptime(dob, '%Y-%m-%d')
    today = datetime.datetime.today()
    return today.year - birth_date.year - ((today.month, today.day) < (birth_date.month, birth_date.day))

def collect_employee_details():
    name = input("Enter Name: ")
    while not validate_name(name):
        print("Invalid name. Please enter alphabetic characters only.")
        name = input("Enter Name: ")

    dob = input("Enter Date of Birth (YYYY-MM-DD): ")
    while not validate_dob(dob):
        print("Invalid date format. Please enter in YYYY-MM-DD format.")
        dob = input("Enter Date of Birth (YYYY-MM-DD): ")

    phone = input("Enter Phone (10 digits): ")
    while not validate_phone(phone):
        print("Invalid phone number. Please enter a 10-digit number.")
        phone = input("Enter Phone (10 digits): ")

    email = input("Enter Email: ")
    while not validate_email(email):
        print("Invalid email format. Please enter a valid email.")
        email = input("Enter Email: ")

    age = calculate_age(dob)
    return {"Name": name, "DOB": dob, "Phone": phone, "Email": email, "Age": age}

def save_to_text(employee_details):
    with open('employee_details.txt', 'w') as file:
        for key, value in employee_details.items():
            file.write(f"{key}: {value}\n")

def save_to_excel(employee_details):
    df = pd.DataFrame([employee_details])
    df.to_excel('employee_details.xlsx', index=False)

def save_to_pdf(employee_details):
    pdf = FPDF()
    pdf.add_page()
    pdf.set_font("Arial", size = 12)
    for key, value in employee_details.items():
        pdf.cell(200, 10, txt = f"{key}: {value}", ln = True)
    pdf.output("employee_details.pdf")

def main():
    employee_details = collect_employee_details()
    print("\nEmployee Details:")
    for key, value in employee_details.items():
        print(f"{key}: {value}")

    print("\nChoose an option to save the details:")
    print("1. Save to Text File")
    print("2. Save to Excel File")
    print("3. Save to PDF File")
    option = input("Enter your choice (1/2/3): ")

    if option == '1':
        save_to_text(employee_details)
        print("Employee details saved to employee_details.txt")
    elif option == '2':
        save_to_excel(employee_details)
        print("Employee details saved to employee_details.xlsx")
    elif option == '3':
        save_to_pdf(employee_details)
        print("Employee details saved to employee_details.pdf")
    else:
        print("Invalid choice. Exiting.")

if __name__ == "__main__":
    main()
