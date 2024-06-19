#include <iostream>

void resta(int* a, int* b, int* resultado)
{
    *resultado = *a - *b;
}

int main()
{
    int a=7, b=2, resultado;
    resta(&a, &b, &resultado);
    std::cout << "Resta de: " << a << "-" << b << " = " << resultado << std::endl;
}
