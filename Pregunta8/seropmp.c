#include <stdio.h>
#include <omp.h>

int main() {
    int NumProcesadores = 7;
    int nTerminos = 15;

    int serie[nTerminos];

    #pragma omp parallel for num_threads(NumProcesadores)
    for (int i = 0; i < nTerminos; i++)
    {
        serie[i]=(i+1)*2;
    }

    printf("Serie : ");
    for (int i = 0; i < nTerminos; i++)
    {
        printf("%d ", serie[i]);
    }
    printf("\n");
}
