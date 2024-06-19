#include "stdio.h"

void division(int *a,  int *b, int *resultado, int *resto)
{
    *resultado = 0;
    *resto = *a;
    while (*resto >= *b)
    {
        *resto =*resto-*b;
        *resultado+=1;
    }
}
int main()
{

    int a=50, b=6,resultado,resto;
    division(&a, &b, &resultado, &resto);
    printf("División de: %d / %d = %d,resto: %d\n", a, b, resultado, resto);
   
}
