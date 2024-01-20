# Heroes contra el monstruo README

## Funcionalidades extra
-Escoger un nombre aleatorio para el monstruo de entre 4
 

##Tests Unitarios
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
Números enteros (Int)

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
Cadenas de carácteres (string)

### Valores límite (en número de caracteres)

[0,1,2...+infinito]


### Clases de equivalencia (en número de carácteres)
clases válidas: [8,9,10...+Infinito]
Siempre y cuando se separen por comas y entre cada coma haya por lo menos un carácter

clases invalidas: [0,1,2,3,4,5,6,7]
### Caso de prueba
string nombres: "a,e,i,o"

Resultado esperado:
arrayNombres = {"a", "e", "i", "o"}

---
## Método damageCalculator

### Dominio
Numeros enteros (Int)

### Valores límite
Para ambas variables de daño y de reducción de daño
Limite superior: +Infinito
Límite inferior: -Infinito

### Clases de equivalencia
Para variable de daño:
Clases validas: [0,1,2...+Infinito]
Clases invalidas: [-Infinito...-2,-1]

Para variable de reducción de daño
Clases validas: [0,1,2...98,99,100]
Clases invalidas: [-infinito...-2,-1] [101,102,103...+Infinito]

### Caso de prueba

daño = 100
reducciónDeDaño = 30;

resultado esperado = 70;

---
## Método druidHealing

### Dominio
Números enteros

### Valores límite
Para el HP actual
Limites: [-Infinito...+Infinito]
+Infinito puede tomar el valor del HP máximo [-Infinito...HPmáximo]

Para el HP máximo
Límites: [1,2,3...+Infinito]

### Clases de equivalencia
Para el HP actual
Clases válidas: [1,2,3...+Infinito]
Clases inválidas: [-Infinito...-2,-1,0]

Para el HP máximo
Clases válidas: [1,2,3...+Infinito]
Clases inválidas: [-Infinito...-2,-1,0]

### Caso de prueba
HPActual = 2000;
HP Máximo = 2100;

Resultado esperado:
HPActual = 2100;
