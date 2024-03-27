#include <iostream>
#include <ctime>
#include <cstdlib>

#define SIZE 5
#define MINES 5

// The game board where -1 represents a mine and other numbers represent the number of mines in the adjacent cells.
int board[SIZE][SIZE];
// Stores whether a cell has been revealed or not.
bool revealed[SIZE][SIZE];

/**
 * Initializes the game board by randomly placing mines.
 */
void init() {
    srand(time(0));
    for(int i = 0; i < MINES; i++) {
        int x = rand() % SIZE;
        int y = rand() % SIZE;
        if(board[x][y] != -1) {
            board[x][y] = -1;
        } else {
            i--;
        }
    }
}

/**
 * Counts the number of mines in the 8 cells surrounding the cell at (x, y).
 * @param x The x-coordinate of the cell.
 * @param y The y-coordinate of the cell.
 * @return The number of mines surrounding the cell.
 */
int countMines(int x, int y) {
    int count = 0;
    for(int i = -1; i <= 1; i++) {
        for(int j = -1; j <= 1; j++) {
            if(x+i >= 0 && x+i < SIZE && y+j >= 0 && y+j < SIZE && board[x+i][y+j] == -1) {
                count++;
            }
        }
    }
    return count;
}

/**
 * Reveals the cell at (x, y). If the cell is a mine, the game ends. Otherwise, it updates the cell with the number of mines in the adjacent cells.
 * @param x The x-coordinate of the cell.
 * @param y The y-coordinate of the cell.
 */
void reveal(int x, int y) {
    if(x >= 0 && x < SIZE && y >= 0 && y < SIZE && !revealed[x][y]) {
        revealed[x][y] = true;
        if(board[x][y] == -1) {
            std::cout << "Game Over\n";
            exit(0);
        } else {
            board[x][y] = countMines(x, y);
        }
    }
}

/**
 * Prints the current state of the game board.
 */
void printBoard() {
    for(int i = 0; i < SIZE; i++) {
        for(int j = 0; j < SIZE; j++) {
            if(revealed[i][j]) {
                if(board[i][j] == -1) {
                    std::cout << "* ";
                } else {
                    std::cout << board[i][j] << " ";
                }
            } else {
                std::cout << "- ";
            }
        }
        std::cout << "\n";
    }
}

/**
 * The main function where the game loop is. It initializes the game, then enters a loop where it prints the board, takes user input for the cell to reveal, and reveals that cell. The loop continues until the game ends (when a mine is revealed).
 * @return 0 when the program successfully ends.
 */
int main() {
    init();
    while(true) {
        printBoard();
        int x, y;
        std::cout << "Enter row and column: ";
        std::cin >> x >> y;
        reveal(x, y);
    }
    return 0;
}