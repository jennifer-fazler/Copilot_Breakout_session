#include <iostream>

// Function to calculate the purity of gold
double calculatePurity(int sensorValue) {
    // Check if the sensor value is valid
    if (sensorValue < 0 || sensorValue > 24) {
        // Print an error message and return -1
        std::cout << "Invalid sensor value. It should be between 0 and 24 Karats." << std::endl;
        return -1;
    }
    return (sensorValue / 24.0) * 100;
}


// Main function
int main() {
    int sensorValue;
    std::cout << "Enter the sensor value in Karats: ";
    std::cin >> sensorValue;

    // Call the function to calculate the purity of gold
    double purity = calculatePurity(sensorValue);
    if (purity != -1) {
        // Print the purity of gold
        std::cout << "The purity of the gold is: " << purity << "%" << std::endl;
    }

    return 0;
