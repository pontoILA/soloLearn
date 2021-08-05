#include <iostream>
using namespace std;

int main() {
    int ages[5], youngest;
    double value=50;

    for (int i = 0; i < 5; ++i) {
        cin >> ages[i];
    }
    //your code goes here
    youngest = ages[0];
    for (int i = 0; i < 5; ++i) {
        if(ages[i]<youngest){
            youngest = ages[i];
        }
    }

    value *=1-(youngest/100.0);
    cout << value;
    
    return 0;
}
