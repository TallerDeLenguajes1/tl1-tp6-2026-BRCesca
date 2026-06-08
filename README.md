## Respuestas Ejercicio 4

1. **¿String es un tipo por valor o un tipo por referencia?**
   El tipo `string` en C# es un **tipo por referencia**. Al igual que las clases explicadas en la teoría (que actúan como estructuras que encapsulan datos y se guardan en el Heap), un string genera una instancia en memoria de forma dinámica. Sin embargo, tiene un comportamiento especial de inmutabilidad (cualquier modificación genera un nuevo objeto en memoria) y sus operadores de comparación están modificados para evaluar el contenido del texto.

2. **¿Qué secuencias de escape tiene el tipo string?**
   Las secuencias de escape permiten insertar caracteres especiales o de control dentro de una cadena de texto anteponiendo la barra invertida (`\`). Las más comunes en C# son:
   * `\n` : Salto de línea.
   * `\t` : Tabulador horizontal.
   * `\"` : Comilla doble (permite incluir comillas dentro del texto sin cerrar la cadena).
   * `\\` : Barra invertida literal.
   * `\r` : Retorno de carro.

3. **¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?**
   * **El carácter `$` (Interpolación de cadenas):** Permite incrustar variables o expresiones directamente dentro del texto usando llaves `{variable}`. C# evalúa y transforma automáticamente lo que esté dentro de las llaves a su representación en texto (equivalente a usar un `.ToString()`), haciendo el código mucho más legible.
   * **El carácter `@` (Cadenas verbatim):** Le indica al compilador que tome la cadena de forma totalmente literal, ignorando todas las secuencias de escape. Es muy útil para escribir rutas de archivos (por ejemplo, `@"C:\Proyectos\tucuman"`) o textos largos que abarcan múltiples renglones.