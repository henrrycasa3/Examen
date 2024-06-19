#include <stdio.h>
#include <omp.h>

#define N 4

void multiplicacion_matriz_vector(int matriz[N][N], int vector[N], int resultado[N]) {
    #pragma omp parallel for
    for (int i = 0; i < N; i++) {
        resultado[i] = 0;
        for (int j = 0; j < N; j++) {
            resultado[i] += matriz[i][j] * vector[j];
        }
    }
}

int main() {
    int matriz[N][N] = {
        {1, 2, 3, 4},
        {5, 6, 7, 8},
        {9, 10, 11, 12},
        {13, 14, 15, 16}
    };

    int vector[N] = {1, 2, 3, 4};
    int resultado[N];

    multiplicacion_matriz_vector(matriz, vector, resultado);

    printf("Resultado vector: ");
    for (int i = 0; i < N; i++) {
        printf("%d ", resultado[i]);
    }
    printf("\n");

    return 0;
}
