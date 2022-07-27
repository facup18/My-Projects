#include "habilidadMod.h"

void darNombreHab(habilidad hab, string& nom)
{
	strcop(nom, hab.nombreHab);
}

date darFchManifestacion(habilidad hab)
{
	return hab.fchManifestacion;
}

long int darCedulaHab(habilidad hab)
{
	return hab.cedulaHab;
}

tipoHab darTipoHab(habilidad hab)
{
	return hab.tipo;
}

void scanNombreHab(habilidad& hab)
{
	strcrear(hab.nombreHab);
	scan(hab.nombreHab);
}

void scanFchManifestacion(habilidad& hab)
{
	loadDate(hab.fchManifestacion);
}

void scanCedulaHab(habilidad& hab)
{
	scanf("%li", &hab.cedulaHab);
}

void scanTipoHab(habilidad& hab)
{
	int op;
	do
	{
		printf("\n1- Natural\n2- Poco natural\n3- Sobre Natural");
		scanf("%i", &op);

		switch (op)
		{
		case 1:
			hab.tipo = natural;
			break;
		case 2:
			hab.tipo = pocoNatural;
			break;
		case 3:
			hab.tipo = sobreNatural;
			break;
		default:
			printf("\nOpcion invalida");
			op = 0;
			break;
		}
	} while (op == 0);
}


void cargarHab(habilidad& hab)
{
	printf("Ingrese nombre de la habilidad: ");
	scanNombreHab(hab);

	printf("\nIngrese fecha de manifestacion de la habilidad: ");
	scanFchManifestacion(hab);


	printf("\nIngrese tipo de habilidad: ");
	scanTipoHab(hab);

	printf("\nIngrese la cedula del socio que manifiesta la habilidad: ");
	scanCedulaHab(hab);
}

void mostrarHab(habilidad hab) {
	string nom;
	strcrear (nom);
	darNombreHab(hab, nom);
	printf("|Nombre de la habilidad: ");
	print(nom);
    printf("|  ");
	printf("|Fecha de manifestacion: ");
	printDate(darFchManifestacion(hab));
    printf("|  ");
	printf("|Tipo de la habilidad: ");
	mostrarTipo(hab.tipo);
    printf("|  ");
	printf("|La cedula del socio que manifiesta la habilidad es: %li|", darCedulaHab(hab));
}

void bajarHabilidad(habilidad hab, FILE* f)
{
	Bajar_String(hab.nombreHab, f);
	bajarFecha(hab.fchManifestacion, f);
	fwrite(&hab.cedulaHab, sizeof(long int), 1, f);
	fwrite(&hab.tipo, sizeof(tipoHab), 1, f);
}

void levantarHabilidad(habilidad& hab, FILE* f)
{
	Levantar_String(hab.nombreHab, f);
	levantarFecha(hab.fchManifestacion, f);
	fread(&hab.cedulaHab, sizeof(long int), 1, f);
	fread(&hab.tipo, sizeof(tipoHab), 1, f);
}
