#include <stdio.h>
#include "tipoHabMod.h"


void mostrarTipo(tipoHab tHab)
{
	switch (tHab)
	{
	case natural:
		printf("Natural");
		break;
	case pocoNatural:
		printf("Poco natural");
		break;
	case sobreNatural:
		printf("Sobre natural");
		break;
	}
}