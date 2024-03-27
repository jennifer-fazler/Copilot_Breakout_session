# SWIFT BIC File Processor in C#

This is a simple console-based application written in C# that reads SWIFT BIC payment data from a text file and inserts it into a database.

## Description

The application uses a `SwiftBic` class to represent a payment record. Each `SwiftBic` object has the following properties:

- `SwiftCode`: The SWIFT code of the bank.
- `PaymentAmount`: The amount of the payment.
- `PaymentCurrency`: The currency of the payment.
- `PaymentDate`: The date of the payment.
- `BicCode`: The BIC code of the bank.

The application reads the payment data from a text file, validates each record, and if the record is valid, adds it to a list of `SwiftBic` objects. Finally, it inserts the list of `SwiftBic` objects into a database.

## How to Run

To run the application, you need to have .NET Core installed on your machine. If you don't have it installed, you can download it from the [official .NET website](https://dotnet.microsoft.com/download).

Once you have .NET Core installed, follow these steps:

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

Remember to replace `Program.cs` with the actual name of your C# file.

## Example Usage

Here is an example of how to use the application:

1. Create a text file named `SWIFTBIC.TXT` with the following content:

    ```
    BANKUSAA1234567.89US20220101BANKUSBB
    BANKGBBB1234567.89GB20220101BANKGBCC
    ```

2. Run the application. It will read the text file, validate the records, and insert them into the database.

## Error Handling

The application handles file I/O errors by catching `IOException` and displaying an error message. It also validates each record and displays an error message for invalid records.