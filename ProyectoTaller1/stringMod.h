#ifndef stringMod
#define stringMod

#include "booleanMod.h" 

const int MAX = 80;
typedef char* string;
//Crea un string vac�o.
void strCrear(string& s);
//Libera la memoria usada por el string.
void strDestruir(string& s);
//Devuelve el largo del string s.
int strLar(string s);
//Copia el contenido del string s2 en s1.
void strCop(string& s1, string s2);
//Lee el string s desde teclado.
void strScan(string& s);
//Imprime el string s por pantalla.
void strPrint(string s);
//Compara dos strings para ver si son exactamente iguales siendo case-sensitive
boolean strEq(string s1, string s2);

boolean strmen(string s1, string s2);

boolean strEsAlfabetico(string s);

boolean strEsNumerico(string s);

boolean validarNomArch(string s);
int strToInt(string s);
int strContPalabras(string s);
/*Escribe en el archivo los caracteres del string s
Precondici�n: El archivo viene abierto para escritura.*/
void Bajar_String(string s, FILE* f);
/*Lee desde el archivo los caracteres del string s.
Precondici�n: El archivo viene abierto para lectura.*/
void Levantar_String(string& s, FILE* f);

#endif
