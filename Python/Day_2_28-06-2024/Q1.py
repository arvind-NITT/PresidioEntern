array = [0] * 26

str = "arvindwhyareyouoffcampleaseturnonyourcamerasqwertyuioplkjhgfdsazxcvbnm"

i = 0
ans = 0
j = i
ans_str=""
while i < len(str):
    while j < len(str):
        if array[ord(str[j]) - 97] == 0:
            array[ord(str[j]) - 97] = 1
            j += 1
        else:
            break
    
    if ans < j - i:
        ans = j - i
        ans_str = str[i:j]
        # print(ans_str)
    if j >= len(str) : 
        break
    while i < len(str) and j < len(str) and array[ord(str[j]) - 97] > 0:
        array[ord(str[i]) - 97] -= 1
        i += 1
    
print(ans_str)
