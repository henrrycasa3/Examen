import multiprocessing as np
from multiprocessing import Pool
import math

def fibo(inicial,final):
  v = []
  for i in range(inicial,final):
    p1=(1/math.sqrt(5))*(((1+math.sqrt(5))/2)**i)
    p2=(1/math.sqrt(5))*(((1-math.sqrt(5))/2)**i)
    pt=p1-p2
    v.append(int(pt))
  return v

if __name__=="__main__":
  limite = 700
  parametros = [((i*limite),(limite*(i+1))) for i in range(np.cpu_count())]
  pool =Pool()
  resultado = pool.starmap(fibo, parametros)
  fibonacci_completo = []
  for i in resultado:
        fibonacci_completo.extend(i)

  print("Fibonacci:", fibonacci_completo)
  print("La cantidad de elementos en el vector es:", len(fibonacci_completo))