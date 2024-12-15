#include <iostream>
#include <vector>
#include <string>
#include <sstream>

int main() {
    // std::string firstNames[5];
    std::vector<std::string> firstNames;

    firstNames.push_back("Tim");
    firstNames.push_back("Sue");
    firstNames.push_back("Bob");
    firstNames.push_back("Jane");
    firstNames.push_back("Frank");

    std::cout << firstNames[firstNames.size() - 1] << std::endl;

    std::vector<int> ages;
    ages.push_back(1);
    ages.push_back(2);
    ages.push_back(3);

    // std::vector<T> - generic

    std::string data = "Corey,Smith,Jones";
    std::vector<std::string> lastNames;
    std::stringstream ss(data);
    std::string item;

    while (std::getline(ss, item, ',')) {
        lastNames.push_back(item);
    }
    lastNames.push_back("Franklin");

    return 0;
}
