#ifndef abbMod
#define abbMod
#include "secMod.h"
#include "booleanMod.h"

typedef struct nodoA {
    Sec info;
    nodoA* hizq;
    nodoA* hder;
}nodo;

typedef nodo* Arbol;


//Crear arbol vacio.
void CrearAbb(Arbol& a);

//Devuelve TRUE si el arbol esta vacio y FALSE en caso contrario.
boolean EsVacio(Arbol a);

//Inserta un socio en el arbol.
void Insert(Arbol& a, Sec secu);

//Lista las caracteristicas de los socios en orden segun su cedula.
void Orden(Arbol a);

//Devuelve TRUE si la cedula dada coincide con la cedula de un socio en el arbol.
boolean existeSec(Arbol a, string id);

//Devuelve el socio que tenga la misma cedula que la ingresada.
//Preconcicion: El socio existe.

Sec darSec(string ident, Arbol a);

Arbol darPuntSec(string id, Arbol a);

void deleteAbb(Arbol& a);

#endif // !abbMod

