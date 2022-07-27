#ifndef booleanMod
#define booleanMod
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>

//Definición de tipo de datos.
typedef enum {FALSE, TRUE}boolean;
//Cabezales sintácticos de subprogramas.

/*Carga una variable de tipo boolean, int 0 = FALSE, int 1 = TRUE.*/
void setBool(boolean &b);

/*Muestra "Verdadero" si la variable tipo boolean es TRUE, "Falso" si es FALSE.*/
void printBool(boolean b);
#endif
