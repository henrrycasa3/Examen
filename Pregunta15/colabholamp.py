import multiprocessing
import time

def metodo1():
    print("Hola 1")
    time.sleep(5)
    print("Mundo 1")

def metodo2():
    print("Hola 2")
    time.sleep(5)
    print("Mundo 2")

def metodo3():
    print("Hola 3")
    time.sleep(5)
    print("Mundo 3")

def paralelo():
    p1 = multiprocessing.Process(target=metodo1)
    p2 = multiprocessing.Process(target=metodo2)
    p3 = multiprocessing.Process(target=metodo3)

    p1.start()
    p2.start()
    p3.start()

    p1.join()
    p2.join()
    p3.join()

if __name__ == "__main__":
    print("Cantidad de procesadores:", multiprocessing.cpu_count())
    paralelo()