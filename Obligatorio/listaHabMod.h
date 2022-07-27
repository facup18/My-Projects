#ifndef listaHabMod
#define listaHabMod
#include "habilidadMod.h"

typedef struct nodoHabL {
    habilidad info;
    nodoHabL* sig;
}nodoHab;

typedef nodoHab* Lista;

void Crear(Lista& L);

void Mostrar(Lista L);

boolean Vacia(Lista L);

//void Primero(Lista L, habilidad& hab);
habilidad Primero(Lista L);
void Resto(Lista& L);
void contHab(Lista L,int &contNat,int &contPocoNat,int &contSobreNat);
//Precondicion: el elemento a insertar debe tener una fecha posterior al ultimo ingresado.
//Tiene que existir un socio que se corresponda con la cedula de la habilidad
void InsFront(Lista& L, habilidad hab);

int cantHabEntreFecha(Lista L,date dt1,date dt2);

boolean existeHab(Lista L, long int ced);

//void eliminarLista(Lista& L);

// Abre el archivo para escritura y escribe los datos de todas las
// personas que están almacenadas en la lista
void Bajar_Lista(Lista L, FILE *f);

// Abre el archivo para lectura y carga en la lista los datos de
// todas las personas que están almacenadas en el archivo (llamando
// al procedimiento InsBack).
void Levantar_Lista(Lista& L, FILE *f);



#endif // !listaHabMod
