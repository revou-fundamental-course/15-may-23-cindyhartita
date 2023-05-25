# Program kalkulator matematik persegi dan persegi panjang

#include <iostream>
using namespace std;

int main()
{
    float p, l, luas;
    cout << "Masukkan panjang persegi panjang: ";
    cin >> p;
    cout << "Masukkan lebar persegi panjang: ";
    cin >> l;
    luas = p * l;
    cout << "Luas persegi panjang adalah " << luas << endl;

    float sisi, luas2;
    cout << "Masukkan sisi persegi: ";
    cin >> sisi;
    luas2 = sisi * sisi;
    cout << "Luas persegi adalah " << luas2;

    return 0;
}

