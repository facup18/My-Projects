#include "listaNumMod.h"

void lstCrear(ListaNum & L)
{
	L = NULL;
}

void lstMostrar(ListaNum L)
{
	printf("[");
	while (L != NULL) {
		printf("%i",L->info);
		L = L->sig;
		if (L != NULL)
			printf(" ");
	}
	printf("]");
}

boolean lstVacia(ListaNum L)
{
	boolean es = FALSE;
	if (L == NULL)
		es = TRUE;
	return es;
}

void insFront(ListaNum& L, int num)
{
	ListaNum aux = new nodoNum;
	aux->info = num;
	aux->sig = L;
	L = aux;
}

void insBackNum(ListaNum& L, int num)
{
	if (L == NULL)
	{
		L = new nodoNum;
		L->info = num;
		L->sig = NULL;
	}
	else
		insBackNum(L->sig, num);
}

int lstSumar(ListaNum L) {
	if (L == NULL) {
		return 0;
	}
	else {
		return (L->info) + lstSumar(L->sig);
	}
}

void lstInvertir(ListaNum L1, ListaNum& L2) {
	while (L1 != NULL)
	{
		insFront(L2, L1->info);
		L1 = L1->sig;
	}
}

void lstConcatenar(ListaNum L1, ListaNum L2, ListaNum& L3) {
	while (L1 != NULL)
	{
		insBackNum(L3, L1->info);
		L1 = L1->sig;
	}
	while (L2 != NULL)
	{
		insBackNum(L3, L2->info);
		L2 = L2->sig;
	}
}

void Bajar_Lista(ListaNum L, FILE *f)
{
	while (L != NULL)
	{
		fwrite(&L->info, sizeof(int),1,f);
		L = L->sig;
	}
}
void Levantar_Lista(ListaNum& L, FILE* f)
{
	int buffer;
	fread(&buffer,sizeof(int), 1,f);
	while (!feof(f))
	{
		insBackNum(L, buffer);
		fread(&buffer, sizeof(int), 1, f);
	}
}
