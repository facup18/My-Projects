#include "secMod.h"

string darIdent(Sec secu)
{
	return secu.ident;
}

void secCrear(Sec &secu, string id)
{
	strCrear(secu.ident);
	strCop(secu.ident, id);
	lstCrear(secu.Nums);
}

ListaNum darLstNum(Sec secu)
{
	return secu.Nums;
}

void secMostrar(Sec secu)
{
	strPrint(secu.ident);
	printf(" = ");
	lstMostrar(secu.Nums);
}

void Bajar_Sec(Sec secu, string nomArch)
{
	FILE* f = fopen(nomArch, "wb");
	Bajar_String(secu.ident, f);
	Bajar_Lista(secu.Nums, f);
	fclose(f);
}

void Levantar_Sec(Sec& secu, string nomArch)
{
	FILE* f = fopen(nomArch, "rb");
	Levantar_String(secu.ident, f);
	Levantar_Lista(secu.Nums, f);
}
