#include "socioMod.h"

void darNombreSoc(socio soc, string& nom)
{
	strcop(nom, soc.nombre);
}

long int darCedula(socio soc)
{
	return soc.cedula;
}

date darFchNacimiento(socio soc)
{
	return soc.nac;
}

boolean darEsInmortal(socio soc)
{
	return soc.esInmortal;
}

void darDimension(socio soc, string& dim)
{
	strcop(dim, soc.dimension);
}

categoria darCatMagica(socio soc)
{
	return soc.catMagica;
}

void scanNombreSoc(socio& soc)
{
	strcrear(soc.nombre);
	scan(soc.nombre);
}

void scanCedula(socio& soc)
{
	scanf("%li", &soc.cedula);
}

void scanFchNacimiento(socio& soc)
{
	loadDate(soc.nac);
}

void scanEsInmortal(socio& soc)
{
	setBool(soc.esInmortal);
}

void scanDimension(socio& soc)
{
	strcrear(soc.dimension);
	scan(soc.dimension);
}

void scanCatMagica(socio& soc)
{
	int op;
	do
	{
		printf("\n1- Brujo\n2- Hada\n3- Hechicero\n");
		scanf("%i", &op);

		switch (op)
		{
		case 1:
			soc.catMagica = Brujo;
			break;
		case 2:
			soc.catMagica = Hada;
			break;
		case 3:
			soc.catMagica = Hechicero;
			break;
		default:
			printf("\nOpcion invalida");
			op = 0;
			break;
		}
	} while (op == 0);
}

void cargarSocio(socio& soc)
{
	printf("Ingrese nombre del socio\n");
	scanNombreSoc(soc);

	printf("\nIngrese cedula magica del socio\n");
	scanCedula(soc);

	printf("\nIngrese fecha de nacimiento\n");
	scanFchNacimiento(soc);

	printf("\nEs inmortal?\n");
	scanEsInmortal(soc);

	printf("\nIngrese la dimension de origen\n");
	scanDimension(soc);

	printf("\nIngrese categoria magica del socio\n");
	scanCatMagica(soc);
}

void mostrarSocio(socio& soc)
{
	string aux;
	strcrear(aux);

	darNombreSoc(soc, aux);

	printf("|Nombre: ");
	print(aux);
    printf("|  ");
	printf("|Cedula: %li|  ", darCedula(soc));
	printf("|Fecha de nacimiento: ");
	printDate(darFchNacimiento(soc));
    printf("|  ");
	printf("|Inmortal: ");
	if (darEsInmortal(soc))
		printf("Si|  ");
	else
		printf("No|  ");

	darDimension(soc, aux);

	printf("|Dimension: ");
	print(aux);
	printf("|  ");

	printf("|Categoria magica: ");
	mostrarCatMagica(darCatMagica(soc));
	printf("|  ");
}


boolean tieneHab(socio soc, Lista L){
    return existeHab(L,darCedula(soc));
}

void mostrarHabSoc(socio soc, Lista L){
    while (L != NULL) {
        if(darCedulaHab(L->info) == darCedula(soc))
            mostrarHab(L->info);
		printf("\n");
		L = L->sig;
	}
}

int cantHabSobreNat(socio soc, Lista L){
    int cont = 0;
    while (L != NULL) {
        if(darTipoHab(L->info) == sobreNatural)
            cont++;
		L = L->sig;
	}
	return cont;
}


void bajarSocio(socio soc, FILE* f)
{
	Bajar_String(soc.nombre, f);
	fwrite(&soc.cedula, sizeof(long int), 1, f);
	bajarFecha(soc.nac, f);
	fwrite(&soc.esInmortal, sizeof(boolean), 1, f);
	Bajar_String(soc.dimension, f);
	fwrite(&soc.catMagica, sizeof(categoria), 1, f);
}

void levantarSocio(socio& soc, FILE* f)
{
	Levantar_String(soc.nombre, f);
	fread(&soc.cedula, sizeof(long int), 1, f);
	levantarFecha(soc.nac, f);
	fread(&soc.esInmortal, sizeof(boolean), 1, f);
	Levantar_String(soc.dimension, f);
	fread(&soc.catMagica, sizeof(categoria), 1, f);
}
