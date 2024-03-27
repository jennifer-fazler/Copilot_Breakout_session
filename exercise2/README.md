# Console Minesweeper in C#

This is a simple console-based implementation of the classic game Minesweeper, written in C#.

## Description

The game is played on a 5x5 grid and there are 5 mines hidden on the board. The goal is to reveal all the cells on the board that do not contain a mine.

## How to Play

On each turn, you will be asked to enter the row and column of the cell you want to reveal. Rows and columns are both numbered from 0 to 4.

If you reveal a cell that contains a mine, the game is over. If you reveal a cell that does not contain a mine, you will be shown the number of mines in the adjacent cells.

The game continues until you reveal a mine or you reveal all the cells that do not contain a mine.

## How to Run

To run the game, you need to have the .NET Core SDK installed on your machine. If you don't have it installed, you can download it from the [official .NET website](https://dotnet.microsoft.com/download).

Once you have the .NET Core SDK installed, follow these steps:

1. Save the C# code in a file with a `.cs` extension, for example, `Program.cs`.

2. Open a command prompt and navigate to the directory containing your `Program.cs` file.

3. Run the following command to compile your C# code into an executable:

    ```bash
    dotnet build
    ```

4. Run the following command to execute your program:

    ```bash
    dotnet run
    ```

## Game Rules

- The game board is a 5x5 grid.
- There are 5 mines hidden on the board.
- On each turn, enter the row and column of the cell you want to reveal.
- If you reveal a cell that contains a mine, the game is over.
- If you reveal a cell that does not contain a mine, you will be shown the number of mines in the adjacent cells.
- The game continues until you reveal a mine or you reveal all the cells that do not contain a mine.
