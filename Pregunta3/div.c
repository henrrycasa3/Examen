#include <stdio.h>
#include <omp.h>

void division(int a, int b, int *resultado, int *resto) {
    *resultado = 0;
    *resto = a;
    
    int temp_resultado = 0;
    int temp_resto = a;

    #pragma omp parallel
    {
        int local_resultado = 0;

        #pragma omp for reduction(+:temp_resultado)
        for (int i = 0; i < a; i++)
        {
            if (temp_resto >= b)
            {
                temp_resto = temp_resto - b;
                local_resultado = local_resultado + 1;
            }
        }
        
        temp_resultado = temp_resultado + local_resultado;
    }

    *resultado = temp_resultado;
    *resto = temp_resto;
}

int main()
{
    int a= 50000000, b= 6,resultado,resto;
    division(a, b, &resultado, &resto);
    printf("División de: %d / %d = %d  y resto: %d\n", a, b, resultado, resto);

}
