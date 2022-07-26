#ifndef listaNumMod
#define listaNumMod
#include "stringMod.h"

typedef struct nodoNumL {
    int info;
    nodoNumL* sig;
}nodoNum;

typedef nodoNum* ListaNum;

void lstCrear(ListaNum& L);

void lstMostrar(ListaNum L);

boolean lstVacia(ListaNum L);

void insFront(ListaNum& L, int num);

void insBackNum(ListaNum& L, int num);

void lstConcatenar(ListaNum L1, ListaNum L2, ListaNum& L3);

int lstSumar(ListaNum L);

void lstInvertir(ListaNum L1, ListaNum& L2);
// Abre el archivo para escritura y escribe los datos de todas las
// personas que están almacenadas en la lista
void Bajar_Lista(ListaNum L, FILE* f);
// Abre el archivo para lectura y carga en la lista los datos de
// todas las personas que están almacenadas en el archivo (llamando
// al procedimiento InsBack).
void Levantar_Lista(ListaNum& L, FILE* f);

#endif 