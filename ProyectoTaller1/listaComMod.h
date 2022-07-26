#ifndef listaComMod
#define listaComMod
#include "stringMod.h"

typedef struct nodoComL {
    string info;
    nodoComL* sig;
}nodoCom;

typedef nodoCom* ListaCom;

void lstComCrear(ListaCom& lstCom);

void insBackCom(ListaCom& L, string str);

void lstMostrarCom(ListaCom L);

void strSeparar(string s, ListaCom &lstCom); 

int contParametros(ListaCom lstCom);

void lstDelete(ListaCom& lstCom);
#endif
