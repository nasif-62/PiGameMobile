# Pi Memory Game

A.NET WPF application that tests your ability to memorize the digits of Pi (π).

## How to Play

1. The game starts with "3." displayed on screen
2. Type the next digits of Pi using the number buttons(0 - 9) or decimal point (.)
3. The correct sequence is: 3.1415926535897932384626433832795...
4.Each correct digit advances your progress and updates the decimal counter
5. If you type a wrong digit, you'll see "Wrong Answer!" and the game resets after 2 seconds
6. Use the Reset button to start over at any time

## Features

- *Mobile-friendly interface*: Large touch buttons optimized for mobile use
- *Real-time feedback*: Shows "Correct!" for right answers, "Wrong Answer!" for mistakes
- *Progress tracking*: Displays current Pi digits entered and decimal place counter
- *Auto-reset*: Automatically restarts after wrong answers
- *Visual feedback*: Color - coded status messages(green for correct, red for wrong)

## Requirements

- .NET 9.0 or later
- Windows operating system (WPF application)

## How to Run

1. Clone or download this project
2. Navigate to the project directory
3. Run the following commands:


dotnet build
dotnet run

## Game Rules

- Type digits 0-9 and decimal point (.) only
- Game validates against the actual digits of Pi
- Counter shows how many decimal places you've correctly entered
- Game resets automatically when you make a mistake
- Try to see how many digits of Pi you can memorize!

## Technical Details

- Built with .NET WPF for Windows desktop/tablet
- Contains Pi digits up to 100+ decimal places
- Uses async/await for smooth user experience during wrong answer delays
