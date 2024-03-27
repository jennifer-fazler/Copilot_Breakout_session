# Minesweeper Game in C++

This is a simple implementation of the classic Minesweeper game in C++. The game board is a 5x5 grid with 5 mines randomly placed. The goal of the game is to reveal all cells that are not mines.

## How to Play

The game starts by displaying the game board. Each cell is represented by a "-", and the mines are hidden.

You will be prompted to enter the row and column of the cell you want to reveal. If the cell is a mine, the game ends. If the cell is not a mine, it will be updated with the number of mines in the adjacent cells.

## Code Overview

The code consists of several functions:

- `init()`: Initializes the game board by randomly placing mines.
- `countMines(int x, int y)`: Counts the number of mines in the 8 cells surrounding the cell at (x, y).
- `reveal(int x, int y)`: Reveals the cell at (x, y). If the cell is a mine, the game ends. Otherwise, it updates the cell with the number of mines in the adjacent cells.

## How to Run

To run the game, compile the `exercise2.cpp` file with a C++ compiler and run the resulting executable.

```bash
g++ exercise2.cpp -o minesweeper
./minesweeper