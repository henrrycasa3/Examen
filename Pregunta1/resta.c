#include "stdio.h"

void resta(int *a, int *b, int *resultado)
{
    *resultado = *a - *b;
}
int main()
{

    int a=7, b=2, resultado;
    resta(&a, &b, &resultado);
    printf("Resta de: %d - %d = %d\n", a, b, resultado);

}
