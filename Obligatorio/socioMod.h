#ifndef socioMod
#define socioMod
#include "categoriaMod.h"
#include "listaHabMod.h"

typedef struct {
	string nombre;
	long int cedula;
	date nac;
	boolean esInmortal;
	string dimension;
	categoria catMagica;
}socio;

void darNombreSoc(socio soc, string& nom);
long int darCedula(socio soc);
date darFchNacimiento(socio soc);
boolean darEsInmortal(socio soc);
void darDimension(socio soc, string& dim);
categoria darCatMagica(socio soc);

void scanNombreSoc(socio& soc);
void scanCedula(socio& soc);
void scanFchNacimiento(socio& soc);
void scanEsInmortal(socio& soc);
void scanDimension(socio& soc);
void scanCatMagica(socio& soc);

void cargarSocio(socio& soc);
void mostrarSocio(socio& soc);
boolean tieneHab(socio soc, Lista L);
int cantHabSobreNat(socio soc, Lista L);
//El socio debe existir
void mostrarHabSoc(socio soc, Lista L);
/*Escribe en el archivo los datos del socio soc.
Precondición: El archivo viene abierto para escritura. */
void bajarSocio(socio soc, FILE* f);

// Lee desde el archivo los datos del socio soc.
// Precondición: El archivo viene abierto para lectura.
void levantarSocio(socio& soc, FILE* f);

#endif // !socioMod


