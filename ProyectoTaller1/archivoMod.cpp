#include "archivoMod.h"

boolean existeArch(string nomArch)
{
	boolean existeArchivo = TRUE;
	FILE* f = fopen(nomArch, "rb");
	if (f == NULL)
		existeArchivo = FALSE;
	else
		fclose(f);
	return existeArchivo;

}

boolean Vacio(string nomArch)
{
	boolean vac = FALSE;
	FILE* f = fopen(nomArch, "rb");
	fseek(f, 0, SEEK_END);
	if (ftell(f) == 0)
		vac = TRUE;
	return vac;
}