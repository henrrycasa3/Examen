#include <stdio.h>
#include <mpi.h>

#define N 4 // tamaño de la matriz y el vector

int main(int argc, char *argv[]) {
    int rango, tamanio, i, j;
    int matriz[N][N] = {
        {1, 2, 3, 4},
        {5, 6, 7, 8},
        {9, 10, 11, 12},
        {13, 14, 15, 16}
    };
    int vector[N] = {1, 2, 3, 4};
    int resultado_local[N] = {0}; // Inicializamos el vector
    int resultado[N] = {0}; // Vector resultado final

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rango); // rango (identificador) del proceso actual
    MPI_Comm_size(MPI_COMM_WORLD, &tamanio); // numero total de procesos

    // Enviamos el vector a todos los procesos
    MPI_Bcast(vector, N, MPI_INT, 0, MPI_COMM_WORLD);

    // Calculamos el numero de filas que cada proceso manejara
    int filas_por_proceso = N / tamanio;
    int filas_restantes = N % tamanio;

    // Procesamos las filas asignadas a cada proceso
    for (i = rango * filas_por_proceso; i < (rango + 1) * filas_por_proceso; i++) {
        for (j = 0; j < N; j++) {
            resultado_local[i - rango * filas_por_proceso] += matriz[i][j] * vector[j];
        }
    }

    // Si hay filas restantes, las procesa el ultimo proceso
    if (rango == tamanio - 1) {
        for (i = tamanio * filas_por_proceso; i < N; i++) {
            for (j = 0; j < N; j++) {
                resultado_local[i - rango * filas_por_proceso] += matriz[i][j] * vector[j];
            }
        }
    }

    // Recopilamos los resultados parciales en el proceso 0
    MPI_Gather(resultado_local, filas_por_proceso, MPI_INT, resultado, filas_por_proceso, MPI_INT, 0, MPI_COMM_WORLD);

    // Si hay filas restantes, el proceso 0 las añade al resultado final
    if (rango == 0 && filas_restantes > 0) {
        for (i = tamanio * filas_por_proceso; i < N; i++) {
            for (j = 0; j < N; j++) {
                resultado[i] += matriz[i][j] * vector[j];
            }
        }
    }

    // Imprimimos el vector resultado solo en el proceso 0
    if (rango == 0) {
        printf("Vector resultado:\n");
        for (i = 0; i < N; i++) {
            printf("%d ", resultado[i]);
        }
        printf("\n");
    }

    MPI_Finalize();
    return 0;
}
