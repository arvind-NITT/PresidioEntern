def print_pyramid(rows):
    for i in range(rows):
        # Print leading spaces
        for j in range(rows - i - 1):
            print(" ", end="")
        # Print stars
        for k in range(2 * i + 1):
            print("*", end="")
        # Move to the next line
        print()

def main():
    while True:
        try:
            rows = int(input("Enter the number of rows for the pyramid: "))
            if rows > 0:
                break
            else:
                print("Please enter a positive integer.")
        except ValueError:
            print("Invalid input. Please enter an integer.")

    print_pyramid(rows)

main()
