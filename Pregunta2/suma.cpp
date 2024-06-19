#include <iostream>

void suma(int *a, int *b, int *resultado)
{
    *resultado = *a + *b;
}
int main()
{
    int a = 3, b = 2, resultado;
    suma(&a, &b, &resultado);
    std::cout << "Suma de: " << a << " + " << b << " = " << resultado << std::endl;
}
