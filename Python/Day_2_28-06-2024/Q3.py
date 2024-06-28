def take_input():
    num_players = int(input("Count of Players: "))
    player_dict = {}
    
    for _ in range(num_players):
        score = int(input("Enter the score: "))
        name = input("Enter Player Name: ")
        player_dict[score] = name
    
    return player_dict

def main():
    player_dict = take_input()
    sorted_dict = dict(sorted(player_dict.items(), key=lambda item: item[0], reverse=True))

    top_ten = list(sorted_dict.items())[:10]
    
    print("Top ten players by scores:")
    for score, name in top_ten:
        print(f"Player: {name}, Score: {score}")

main()