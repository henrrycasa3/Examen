#include "stdio.h"

void suma(int *a, int *b, int *resultado)
{
    *resultado = *a + *b;
}
int main()

{
    int a=3, b=2, resultado;
    suma(&a, &b, &resultado);
    printf("Suma de:%d + %d = %d\n", a, b, resultado);
    

}
