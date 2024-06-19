import multiprocessing

def generar_serie(inicio, fin, paso):
    serie = []
    for i in range(inicio, fin, paso):
        serie.append(i)
    return serie

if __name__ == "__main__":
    M = 4  # Número de vectores/procesadores
    N = 10  # Número de terminos
    inicio = 2  # Valor inicial de la serie
    paso = 2  # Paso entre términos de la serie

    pool = multiprocessing.Pool(processes=M)
    parametros = [(inicio + i * N * paso, inicio + (i + 1) * N * paso, paso) for i in range(M)]
    resultados = pool.starmap(generar_serie, parametros)

    serie_completa = []
    for serie in resultados:
        serie_completa.extend(serie)

    print("Serie :", serie_completa)