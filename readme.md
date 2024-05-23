# Preguntas sobre el tipo string en C#

## ¿String es un tipo por valor o un tipo por referencia?

En C#, string es un tipo por referencia. A pesar de ser un tipo por referencia, la clase string tiene un comportamiento especial en el sentido de que es inmutable, es decir, una vez creada una instancia de string, no se puede modificar. Cualquier operación que parezca modificar una cadena en realidad crea una nueva instancia de string.

## ¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape en el tipo string de C# se utilizan para representar caracteres especiales dentro de una cadena. Aquí están algunas de las secuencias de escape más comunes:

- \\ : Barra invertida
- \' : Comilla simple
- \" : Comilla doble
- \n : Nueva línea
- \r : Retorno de carro
- \t : Tabulación horizontal
- \b : Retroceso
- \f : Avance de página
- \v : Tabulación vertical
- \0 : Carácter nulo

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

### Carácter @ (Verbatim Strings)
- El carácter @ se utiliza para definir una cadena literal (verbatim string) que no interpreta las secuencias de escape. Esto permite que las barras invertidas y las comillas dobles sean tratadas como caracteres literales. Es especialmente útil para rutas de archivos y texto multilineal.

### Carácter $ (Interpolated Strings)

- El carácter $ se utiliza para definir una cadena interpolada (interpolated string), que permite insertar expresiones de variables directamente dentro de la cadena utilizando llaves {}.