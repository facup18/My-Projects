#ifndef archivoMod
#define archivoMod
#include "stringDinMod.h"

// Agrega el nuevo entero al final del archivo 
void Agregar(string nomArch, int num);

// Determina si existe o no un archivo con el nombre recibido por parámetro
boolean Existe(string nomArch);

// Determina si el archivo está vacío o no. Precondición: El archivo existe
boolean Vacio(string nomArch);

// Determina si el entero recibido está en el archivo. Precondición: El archivo existe
boolean Pertenece(string nomArch, int entero);

#endif // !archivoMod

