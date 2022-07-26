#ifndef parsingMod
#define parsingMod
#include "listaComMod.h"
#include "abbMod.h"
#include "archivoMod.h"

typedef enum{create, insback, show, sum, concat, reverse, save, load, exit, null}comando;

comando strToCom(string str);

void parsing();

void comCreate(ListaCom lstCom, Arbol& a);
void comInsBack(ListaCom lstCom, Arbol& a);
void comShow(ListaCom lstCom, Arbol& a);
void comSum(ListaCom lstCom, Arbol& a);
void comConcat(ListaCom lstCom, Arbol& a);
void comReverse(ListaCom lstCom, Arbol& a);
void comSave(ListaCom lstCom, Arbol& a);
void comLoad(ListaCom lstCom, Arbol& a);

#endif // !"parsingMod.h"