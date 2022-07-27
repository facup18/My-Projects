#ifndef arbolMod
#define arbolMod
#include "socioMod.h"

typedef struct nodoA {
    socio info;
    nodoA* hizq;
    nodoA* hder;
}nodo;

typedef nodo* Arbol;

void CrearAbb(Arbol& a);

boolean EsVacio(Arbol a);

socio DarRaiz(Arbol a);

Arbol HijoIzq(Arbol a);

Arbol HijoDer(Arbol a);

void Insert(Arbol& a, socio soc);

void PreOrden(Arbol a);

void Orden(Arbol a);

void PostOrden(Arbol a);

int ContarNodo(Arbol a);

//boolean EsHoja(Arbol a, socio soc);

//int Profundidad(Arbol a, socio soc);

void Eliminar(Arbol& a);

boolean existeSocio(Arbol a, long int ced);

int contarNacAnterior(Arbol a, date dte);

void contSociosCat(Arbol a,int &contHada,int &contBrujo,int &contHechicero);

void mostrarSocioSinHab(Arbol a,socio &soc,Lista L);

void socioPoderoso(socio soc)
// Escribe en el archivo los datos de todos los enteros del árbol
// en forma recursiva.
// Precondición: El archivo viene abierto para escritura.
void Bajar_ABB(Arbol a, FILE* f);
// Abre el archivo para escritura y escribe los datos de todos los
// enteros del árbol (llamando al procedimiento anterior)
//void Bajar_ABB(Arbol a, string nomArch);
// Abre el archivo para lectura e inserta en el árbol todos los
// enteros están en el archivo (llamando al procedimiento Insert).
// Precondición: El archivo existe.
void Levantar_ABB(Arbol& a,FILE *f);
//void Levantar_ABB(Arbol& a, string nomArch);


#endif // arbolMod
