#include <iostream>

void multiplicacion(int* a, int* b, int* resultado)
{
    *resultado = 0;
    for (int i = 1; i <= *b; i++) {
        *resultado += *a;
    }
}

int main() 
{
    int a=6, b=5, resultado;
    multiplicacion(&a, &b, &resultado);
    std::cout << "Multiplicación de:" << a << "*" << b << "=" << resultado << std::endl;
}

