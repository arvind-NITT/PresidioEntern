def get_permutations(string):
    if len(string) == 1:
        return [string]
    
    permutations = []
    for i, char in enumerate(string):
        # Exclude the current character and get permutations of the remaining characters
        remaining = string[:i] + string[i+1:]
        for p in get_permutations(remaining):
            permutations.append(char + p)
    
    return permutations

def main():
    input_string = input("Enter a string: ")
    permutations = get_permutations(input_string)
    print(f"All permutations of the string '{input_string}':")
    for perm in permutations:
        print(perm)

main()
