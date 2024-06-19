#include <iostream>

void division(int *a, int *b, int *resultado, int *resto)
{
    *resultado = 0;
    *resto = *a;
    while (*resto >= *b)
    {
        *resto = *resto - *b;
        *resultado += 1;
    }
}

int main()
{
    int a = 50, b = 6, resultado, resto;
    division(&a, &b, &resultado, &resto);
    std::cout << "División de: " << a << " / " << b << " = " << resultado << ", resto: " << resto << std::endl;
}
