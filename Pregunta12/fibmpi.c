#include <mpi.h>
#include <stdio.h>

// Función para calcular el término de Fibonacci (recursiva simple)
int fibonacci(int n) {
    if (n <= 1)
        return n;
    else
        return fibonacci(n - 1) + fibonacci(n - 2);
}

int main(int argc, char* argv[]) {
    int rango, tamaño;
    int num_terminos = 20;  // Número de términos de Fibonacci a calcular
    int resultado;

    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rango);
    MPI_Comm_size(MPI_COMM_WORLD, &tamaño);

    if (tamaño == 1) {
        // Si solo hay un proceso, el MASTER hará todo el trabajo
        for (int i = 0; i < num_terminos; i++) {
            resultado = fibonacci(i);
            printf("Fibonacci(%d) = %d\n", i, resultado);
        }
    } else {
        if (rango == 0) { // MASTER
            int terminos[num_terminos];

            // Solicitar a los SLAVES que calculen los términos
            for (int i = 0; i < num_terminos; i++) {
                int esclavo = (i % (tamaño - 1)) + 1; // Distribuir entre SLAVES
                MPI_Send(&i, 1, MPI_INT, esclavo, 0, MPI_COMM_WORLD);
                MPI_Recv(&resultado, 1, MPI_INT, esclavo, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
                terminos[i] = resultado;
                printf("Fibonacci(%d) = %d\n", i, resultado);
            }

            // Enviar mensaje de terminación a los SLAVES
            for (int i = 1; i < tamaño; i++) {
                int parar = -1;
                MPI_Send(&parar, 1, MPI_INT, i, 0, MPI_COMM_WORLD);
            }
        } else { // SLAVES
            while (1) {
                MPI_Recv(&num_terminos, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
                if (num_terminos == -1) // Mensaje de terminación
                    break;
                resultado = fibonacci(num_terminos);
                MPI_Send(&resultado, 1, MPI_INT, 0, 0, MPI_COMM_WORLD);
            }
        }
    }

    MPI_Finalize();
    return 0;
}
