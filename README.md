**ShackIdaElias**

**K1 Project Submission**

♟️ **ChessBoard**

A console-based chessboard built in C# and .NET.

The program allows the user to choose the size of the chessboard and then prints the board in the console.

🚨 **Requirements**

.NET 10

Git


🔧 **Clone, Build and Run**

Clone the project: git clone https://github.com/Jaktlund96/ShackIdaElias.git

Go to the project directory: cd ChessBoard

Build the project: dotnet build

Run the program: dotnet run

🎮 **Usage**

When the program starts, the user is asked to enter the size of the chessboard.

The size must be between 3 and 50.

Example:

Enter the board size by typing a number between 3–50:

8

This results in an 8 × 8 chessboard:
```
□ ■ □ ■ □ ■ □ ■
■ □ ■ □ ■ □ ■ □
□ ■ □ ■ □ ■ □ ■
■ □ ■ □ ■ □ ■ □
□ ■ □ ■ □ ■ □ ■
■ □ ■ □ ■ □ ■ □
□ ■ □ ■ □ ■ □ ■
■ □ ■ □ ■ □ ■ □
```
📦 **NuGet Package**

Spectre.Console

The project uses the Spectre.Console package. It was chosen to create a more visually appealing game.

We chose to make the background of the first line of text blue so that something would happen visually as soon as the game was opened.

We chose not to do this for additional lines of text because we felt that it would look too cluttered and less visually appealing.

🏗 **Code Structure**

The Chess class represents the chessboard and contains, among other things:

Size – specifies the size of the chessboard.
ReadSize() – reads and validates the user's input.
RenderBoard() – creates and prints the chessboard in the console.

🔀 **Git Workflow**

The project was version controlled using Git. We made commits continuously throughout the development process to save different changes.

A merge conflict occurred during the development process when one of the developers accidentally saved a local change on their computer.

This was resolved by clicking "Pending Changes" in Visual Studio, where the change was visible, and then clicking "Undo".

Another merge conflict occurred towards the end of the project. While Person A was installing the NuGet package and adding the relevant code, Person B was editing the README file.

This resulted in an error message when Person A tried to run git push, because they did not have the latest version of the project. This was resolved by running git pull before git push.

⚙ **Technical Choices**

The user's input is validated using int.TryParse() to ensure that the input can be converted into an integer. The size is also checked to make sure that it is between 3 and 50.

The row and column positions are used to alternate between black and white squares. By checking (row + column) % 2, the program can determine which type of square should be printed.

The code is divided into a class and several methods to make the program clearer and to separate different responsibilities.
