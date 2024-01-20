# Heroes contra el monstruo Tests
---
## Método statChecker

### Dominio
Números enteros (Int)

### Valores límite
Para el rango máximo de la stat:
Limite superior: +Infinito
Límite inferior: -Infinito+1

Para el rango mínimo de la stat
Limite superior: +Infinito-1 (Si no supera al rango máximo)
Límite inferior: -Infinito

### Clases de equivalencia
Cualquiera que se encuentre entre los valores de rango mínimo y máximo
Ej:
minArchDamage = 500;
maxArchDamage = 1000;

Clases válidas = [500,501,502...998,999,1000]
Clases inválidas = (-infinito...499] [1001...Infinito)

### Caso de prueba
minArchDamage = 500;
maxArchDamage = 1000;
input = 567;

Resultado esperado: True

---
## Método randomNumberGenerator

### Dominio

### Valores límite
Para el rango máximo del generador:
Limite superior: +Infinito-1
Límite inferior: -Infinito

Para el rango mínimo del generador:
Limite superior: +Infinito-2 (Siempre y cuando no supere al rango maximo)
Límite inferior: -Infinito

### Clases de equivalencia
Cualquiera para ambas variables mientras el rango superior no sea menor al inferior

### Caso de prueba
minRange: 0
maxRange: 6

Resultado esperado: Un número entre 0 y 6 (Comprobado con statCheck)


---
## Método nameArrayGenerator

### Dominio

### Valores límite
Limite superior: 
Límite inferior: 

### Clases de equivalencia

### Caso de prueba



## Método damageCalculator

### Dominio

### Valores límite
Limite superior: 
Límite inferior: 

### Clases de equivalencia

### Caso de prueba



## Método druidHealing

### Dominio

### Valores límite
Limite superior: 
Límite inferior: 

### Clases de equivalencia

### Caso de prueba

