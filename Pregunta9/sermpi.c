#include <stdio.h>
#include <stdlib.h>
#include <mpi.h>

#define N 20 // numero total de terminos de la serie

int main(int argc, char *argv[]) {
    int rango, tamanio, i;
    int inicio, fin; //inicio y fin para cada proceso
    int *serie_local = NULL; // para parte de la serie generada por cada proceso
    int *serie_completa = NULL; // para la serie completa recolectada en el proceso 0

    MPI_Init(&argc, &argv); // Inicializamos MPI
    MPI_Comm_rank(MPI_COMM_WORLD, &rango); // rango del proceso actual
    MPI_Comm_size(MPI_COMM_WORLD, &tamanio); // numero total de procesos

    // calculamos el tamaño de la serie local para cada proceso
    int terminos_por_proceso = N / tamanio;
    int terminos_extra = N % tamanio;
    if (rango < terminos_extra) {
        terminos_por_proceso++;
        inicio = rango * terminos_por_proceso * 2 + 2;
    } else {
        inicio = rango * terminos_por_proceso * 2 + terminos_extra * 2 + 2;
    }
    fin = inicio + terminos_por_proceso * 2 - 1;

    // Generamos la parte de la serie correspondiente a este proceso
    serie_local = (int*)malloc(terminos_por_proceso * sizeof(int));
    if (serie_local == NULL) {
        printf("Error de asignación de memoria.\n");
        MPI_Abort(MPI_COMM_WORLD, 1);
    }

    for (i = 0; i < terminos_por_proceso; i++) {
        serie_local[i] = inicio + i * 2;
    }

    // recopilamos las partes de la serie en el proceso 0
    if (rango == 0) {
        serie_completa = (int*)malloc(N * sizeof(int));
        if (serie_completa == NULL) {
            printf("Error de asignación de memoria.\n");
            MPI_Abort(MPI_COMM_WORLD, 1);
        }
    }

    MPI_Gather(serie_local, terminos_por_proceso, MPI_INT, serie_completa, terminos_por_proceso, MPI_INT, 0, MPI_COMM_WORLD);

    // imprimimos la serie completa solo en el proceso 0
    if (rango == 0) {
        printf("Serie completa:\n");
        for (i = 0; i < N; i++) {
            printf("%d ", serie_completa[i]);
        }
        printf("\n");
        free(serie_completa);
    }

    free(serie_local);
    MPI_Finalize();
    return 0;
}
