import random

def generate_secret_word(word_list):
    return random.choice(word_list)

def get_cows_and_bulls(secret_word, guess):
    cows = 0
    bulls = 0
    for i in range(len(guess)):
        if guess[i] == secret_word[i]:
            bulls += 1
        elif guess[i] in secret_word:
            cows += 1
    return cows, bulls

def play_game(word_list):
    secret_word = generate_secret_word(word_list)
    attempts = 0
    max_attempts = 10
    print("Welcome to the Cow and Bull game!")
    print(f"Try to guess the {len(secret_word)}-letter word. You have {max_attempts} attempts.")

    while attempts < max_attempts:
        guess = input(f"Attempt {attempts + 1}: ").strip().lower()
        if len(guess) != len(secret_word):
            print(f"Please enter a {len(secret_word)}-letter word.")
            continue

        attempts += 1
        cows, bulls = get_cows_and_bulls(secret_word, guess)
        print(f"Cows: {cows}, Bulls: {bulls}")

        if bulls == len(secret_word):
            print(f"Congratulations! You've guessed the word '{secret_word}' in {attempts} attempts.")
            return
        
    print(f"Sorry, you've used all {max_attempts} attempts. The word was '{secret_word}'.")

def main():
    word_list = ["apple", "grape", "mango", "peach", "berry"] 
    play_game(word_list)

if __name__ == "__main__":
    main()
