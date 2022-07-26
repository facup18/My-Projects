#include "abbMod.h"
void CrearAbb(Arbol& a)
{
    a = NULL;
}

boolean EsVacio(Arbol a)
{
    return (boolean)(a == NULL);
}

void Insert(Arbol& a, Sec secu)
{
    if (a == NULL) {
        a = new nodo;
        a->info = secu;
        a->hizq = NULL;
        a->hder = NULL;
    }
    else {
        if (strmen(darIdent(secu), darIdent(a->info)))
            Insert(a->hizq, secu);
        else
            Insert(a->hder, secu);
    }
}

void Orden(Arbol a)
{
    if (a != NULL) {
        Orden(a->hizq);
        secMostrar(a->info);
        printf("\n");
        Orden(a->hder);
    }
}

boolean existeSec(Arbol a, string id) {
    if (a == NULL)
        return FALSE;
    else if (strEq(id, darIdent(a->info)))
        return TRUE;
    else {
        if (strmen(id, darIdent(a->info)))
            return existeSec(a->hizq, id);
        else
            return existeSec(a->hder, id);
    }
}

Sec darSec(string ident, Arbol a) {
    if (strEq(ident, darIdent(a->info)))
        return a->info;
    else
        if (strmen(ident, darIdent(a->info)))
            return darSec(ident, a->hizq);
        else
            return darSec(ident, a->hder);
}

Arbol darPuntSec(string ident, Arbol a) {
   if (strEq(ident, darIdent(a->info)))
        return a;
    else
        if (strmen(ident, darIdent(a->info)))
            return darPuntSec(ident, a->hizq);
        else
            return darPuntSec(ident, a->hder);
}

void deleteAbb(Arbol& a)
{
    if (a != NULL)
    {
        deleteAbb(a->hizq);
        deleteAbb(a->hder);
        delete[] a;
    }
}

