const words = ["apple", "grape", "mango", "peach", "berry", "lemon", "melon"];
const alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".split("");
let selectedCell = null;

document.addEventListener("DOMContentLoaded", () => {
    const wordGrid = document.getElementById("wordGrid");
    const keyboard = document.getElementById("keyboard");

    // Create the word grid
    words.forEach(word => {
        word.split("").forEach(char => {
            const cell = document.createElement("div");
            cell.classList.add("cell");
            cell.dataset.char = char.toUpperCase();
            cell.addEventListener("click", () => {
                if (selectedCell) {
                    selectedCell.classList.remove("selected");
                }
                cell.classList.add("selected");
                selectedCell = cell;
            });
            wordGrid.appendChild(cell);
        });
    });

    // Create the onscreen keyboard
    alphabet.forEach(letter => {
        const key = document.createElement("div");
        key.classList.add("key");
        key.textContent = letter;
        key.addEventListener("click", () => {
            if (selectedCell) {
                if (selectedCell.dataset.char === letter) {
                    selectedCell.classList.add("correct");
                    selectedCell.textContent = letter;
                } else {
                    selectedCell.classList.add("incorrect");
                    //selectedCell.textContent = letter;
                }
                selectedCell.classList.remove("selected");
                selectedCell = null;
            }
        });
        keyboard.appendChild(key);
    });
});
