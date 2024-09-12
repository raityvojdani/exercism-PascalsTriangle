# Pascal's Triangle Generator

This project is a C# console application that generates Pascal's Triangle up to a specified number of rows. Pascal's Triangle is a triangular array of binomial coefficients, where each number is the sum of the two numbers directly above it.

The goal of this project is to demonstrate key concepts of C# like class structure, dependency injection, and following SOLID principles.

## How to Run the Code

1. **Clone or download the repository:**
   ```bash
   git clone https://github.com/raityvojdani/exercism-PascalsTriangle.git
   
Compile and run the program:

Make sure you have .NET SDK installed.
Open a terminal in the project folder and run the following command to compile and execute the code:
 dotnet run

Output:

The program will print Pascal's Triangle for 7 rows by default. You can modify the number of rows inside the Program.cs file.
Example Output
For 7 rows of Pascal's Triangle, the output will look like this:


1 
1 1 
1 2 1 
1 3 3 1 
1 4 6 4 1 
1 5 10 10 5 1 
1 6 15 20 15 6 1



## SOLID Principles in the Code

This project follows several key SOLID principles:

1. **Single Responsibility Principle (SRP):**
   - Each class has a single responsibility. The `PascalsTriangle` class is responsible for generating the triangle, and the `Program` class handles the application logic.

2. **Open/Closed Principle (OCP):**
   - The `PascalsTriangle` class can be extended to include additional features without modifying its existing logic.

3. **Dependency Inversion Principle (DIP):**
   - The `PascalsTriangle` class is created independently of the `Program` class, promoting loose coupling and making the code more testable and maintainable.

