#include "listaComMod.h"

void lstComCrear(ListaCom& lstCom)
{
	lstCom = NULL;
}

void insBackCom(ListaCom& L, string str)
{
	if (L == NULL)
	{
		L = new nodoCom;
		strCrear(L->info);
		strCop(L->info, str);
		L->sig = NULL;
	}
	else
		insBackCom(L->sig, str);
}

void lstMostrarCom(ListaCom L)
{
	while (L != NULL) {
		strPrint(L->info);
		printf(" ");
		L = L->sig;
	}
}

void strSeparar(string s, ListaCom& lstCom)
{
	int i = 0, j, tamPalabra, auxIndex;
	string aux;
	strCrear(aux);
	while (s[i] != '\0')
	{
		if (s[i] != ' '/*(s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i] <= '9')*/) {
			tamPalabra = 0;
			auxIndex = i;
			do {
				auxIndex++;
				tamPalabra++;
			} while (s[auxIndex] != ' ' && s[auxIndex] != '\0');
			delete[] aux;
			strCrear(aux);
			aux = new char[tamPalabra + 1];
			j = 0;
			while (s[i] != ' ' && s[i] != '\0')
			{
				aux[j] = s[i];
				i++;
				j++;
			}
			aux[j] = '\0';
			insBackCom(lstCom, aux);
		}
		if(s[i] != '\0')
			i++;
	}
}

int contParametros(ListaCom lstCom)
{
	int i = 0;

	while (lstCom != NULL)
	{
		lstCom = lstCom->sig;
		i++;
	}
	return i;
}

void lstDelete(ListaCom& lstCom) {
	ListaCom aux;
	while (lstCom != NULL)
	{
		aux = lstCom;
		lstCom = lstCom->sig;
		delete[] aux;
		aux = NULL;
	}
	delete[] lstCom;
}

