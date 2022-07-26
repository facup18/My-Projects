#ifndef secMod
#define secMod
#include "listaNumMod.h"

typedef struct {
	string ident;
	ListaNum Nums;
}Sec;

string darIdent(Sec secu);

ListaNum darLstNum(Sec secu);

void secCrear(Sec &secu, string id);

void secMostrar(Sec secu);

void Bajar_Sec(Sec secu, string nomArch);

void Levantar_Sec(Sec& secu, string nomArch);

#endif