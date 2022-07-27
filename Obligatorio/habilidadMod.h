#ifndef habilidadMod
#define habilidadMod
#include "stringDinMod.h"
#include "dateMod.h"
#include "tipoHabMod.h"

typedef struct {
	string nombreHab;
	date fchManifestacion;
	long int cedulaHab;
	tipoHab tipo;
}habilidad;

void darNombreHab(habilidad hab, string& nom);
date darFchManifestacion(habilidad hab);
long int darCedulaHab(habilidad hab);
tipoHab darTipoHab(habilidad hab);

void scanNombreHab(habilidad& hab);
void scanFchManifestacion(habilidad& hab);
void scanCedulaHab(habilidad& hab);
void scanTipoHab(habilidad& hab);

void cargarHab(habilidad& hab);
void mostrarHab(habilidad hab);


/*Escribe en el archivo los datos del socio soc.
Precondición: El archivo viene abierto para escritura. */
void bajarHabilidad(habilidad hab, FILE* f);

// Lee desde el archivo los datos del socio soc.
// Precondición: El archivo viene abierto para lectura.
void levantarHabilidad(habilidad& hab, FILE* f);

#endif // !habilidadMod

