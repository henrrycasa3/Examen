#include <stdio.h>
#include <omp.h>

void division(int a, int b, int *resultado, int *resto) {
    int resultado_local = 0;
    int resto_local = a;

    // Reducción para combinar resultados locales de cada hilo
    #pragma omp parallel reduction(+:resultado_local)
    {
        int brea = 0;

        while (!brea) {
            // Sección crítica para modificar resto_local de manera segura
            #pragma omp critical
            {
                if (resto_local >= b) {
                    resto_local -= b;
                    resultado_local++;
                } else {
                    brea = 1; 
                }
            }
        }
    }

    *resultado = resultado_local;
    *resto = resto_local;
}

int main() {
    int a = 50000, b = 6, resultado, resto;
    division(a, b, &resultado, &resto);
    printf("División de: %d / %d = %d y resto: %d\n", a, b, resultado, resto);
    return 0;
}
