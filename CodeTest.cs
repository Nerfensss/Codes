#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
    int n, m, a, b, k, c;

    cout << "Введіть кількість людей (n): ";
    cin >> n;

    cout << "Введіть кількість поїздок на кожну людину (m): ";
    cin >> m;

    cout << "Введіть вартість квитка на одну поїздку (a): ";
    cin >> a;

    cout << "Введіть вартість безлімітного квитка на одну людину (b): ";
    cin >> b;

    cout << "Введіть кількість людей для групового квитка (k): ";
    cin >> k;

    cout << "Введіть вартість групового безлімітного квитка (c): ";
    cin >> c;


    int totalCost = 0;
    int groupCount = n / k; 
    int remainingPeople = n % k; 

    totalCost += groupCount * min(c, k * b);
    totalCost += remainingPeople * min(b, a * m);

    cout << "Мінімальна сумарна вартість квитків: " << totalCost << " гривень" << endl;

    return 0;
}

