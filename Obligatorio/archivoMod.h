#ifndef archivoMod
#define archivoMod
#include "stringDinMod.h"

// Agrega el nuevo entero al final del archivo 
void Agregar(string nomArch, int num);

// Determina si existe o no un archivo con el nombre recibido por par�metro
boolean Existe(string nomArch);

// Determina si el archivo est� vac�o o no. Precondici�n: El archivo existe
boolean Vacio(string nomArch);

// Determina si el entero recibido est� en el archivo. Precondici�n: El archivo existe
boolean Pertenece(string nomArch, int entero);

#endif // !archivoMod

