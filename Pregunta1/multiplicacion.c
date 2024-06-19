#include "stdio.h"

void multiplicacion(int *a, int *b, int *resultado)
{
    *resultado = 0;
    for (int i = 1; i <= *b; i++)
    {
        *resultado = *resultado+*a;
    }
}
int main()
{

    int a=6, b=5;
    int resultado;
    multiplicacion(&a, &b, &resultado);
    printf("Multiplicación de: %d * %d = %d\n", a, b, resultado);

}
