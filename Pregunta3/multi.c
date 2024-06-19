#include <stdio.h>
#include <omp.h>

int multiplicacion(int a, int b)
{
    int total=0;
    #pragma omp parallel for reduction(+:total)
    for (int i = 0; i < b; i++)
    {
        total = total + a;
    }
    return total;
}
int main() {
    int a = 10000, b = 324;
    int resultado = multiplicacion(a, b);
    printf("Multiplicación de: %d * %d = %d\n",a,b,resultado);
}

