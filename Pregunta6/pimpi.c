#include <stdio.h>
#include <stdlib.h>
#include <mpi.h>

int main(int argc, char *argv[]) {
    int procesador, nprocesadores;
    long long int num_terminos = 1000000000;
    double pi = 0.0;
    double pi_total = 0.0;

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &procesador);
    MPI_Comm_size(MPI_COMM_WORLD, &nprocesadores);

    long long int terminos_por_proceso = num_terminos / nprocesadores;
    long long int inicio = procesador * terminos_por_proceso;
    long long int fin = inicio + terminos_por_proceso;

    for (long long int i = inicio; i < fin; i++) {
        double termino;
        if (i % 2 == 0) {
            termino = 4.0 / (2 * i + 1);
        } else {
            termino = -4.0 / (2 * i + 1);
        }
        pi += termino;
    }

    MPI_Send(&pi, 1, MPI_DOUBLE, 0, 0, MPI_COMM_WORLD);

    if (procesador == 0) {
        pi_total += pi; 

        for (int i = 1; i < nprocesadores; i++) {
            double suma;
            MPI_Recv(&suma, 1, MPI_DOUBLE, i, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            pi_total += suma;
        }

        printf("VALOR DE PI: %.18f\n", pi_total);
    }

    MPI_Finalize();
}
