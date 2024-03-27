# Simple Phonebook Application in C++

This is a simple console-based phonebook application written in C++. It allows you to add, search, update, and remove contacts.

## Description

The application uses a `std::vector` to store contacts. Each contact is a `Contact` struct that contains the following fields:

- `name`: The name of the contact.
- `address`: The address of the contact.
- `email`: The email address of the contact.
- `phoneNumber`: The phone number of the contact.

The application provides the following functions:

- `addContact`: Adds a new contact to the phonebook.
- `searchContact`: Searches for a contact by name and prints the contact's details.
- `updateContact`: Updates the details of a contact.
- `removeContact`: Removes a contact from the phonebook.

## How to Run

To run the application, you need to have a C++ compiler installed on your machine. If you don't have one installed, you can download one from the [official GCC website](https://gcc.gnu.org/install/index.html).

Once you have a C++ compiler installed, follow these steps:

1. Save the C++ code in a file with a `.cpp` extension, for example, `exercise3.cpp`.
2. Open a command prompt and navigate to the directory containing your `exercise3.cpp` file.
3. Run the following command to compile your C++ code into an executable:

    ```bash
    g++ -o exercise3 exercise3.cpp
    ```

4. Run the following command to execute your program:

    ```bash
    ./exercise3
    ```

Remember to replace `exercise3.cpp` with the actual name of your C++ file.

## Example Usage

Here is an example of how to use the application:

```cpp
int main() {
    addContact("John Doe", "123 Main St", "johndoe@example.com", "123-456-7890");
    addContact("Jane Doe", "456 Elm St", "janedoe@example.com", "098-765-4321");

    searchContact("John Doe");
    updateContact("John Doe", "John Doe", "456 Main St", "johndoe@example.com", "123-456-7890");
    searchContact("John Doe");
    removeContact("John Doe");

    return 0;
}