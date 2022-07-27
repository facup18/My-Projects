#include "listaHabMod.h"

void Crear(Lista& L)
{
	L = NULL;
}

void Mostrar(Lista L)
{
	while (L != NULL) {
		mostrarHab(L->info);
		printf("\n");
		L = L->sig;
	}
}

boolean Vacia(Lista L)
{
	boolean es = FALSE;
	if (L == NULL)
		es = TRUE;
	return es;
}

//void Primero(Lista L, habilidad& hab)
//{
//	hab = L->info;//error
//}
habilidad Primero(Lista L) {
	return L->info;//error
}
void Resto(Lista& L)
{
	Lista aux = L;
	L = L->sig;
	delete aux;
}

void InsFront(Lista& L, habilidad hab)
{
	habilidad aux;
	if (!Vacia(L))
		aux = Primero(L);
	else
		aux = hab;

	if (postEq(darFchManifestacion(hab), darFchManifestacion(aux)))
	{
		Lista aux = new nodoHab;
		aux->info = hab;
		aux->sig = L;
		L = aux;
	}
	else
	{
		printf("\nLa habilidad que intenta ingresar no tiene una fecha posterior a la ultima ingresada");
	}

}

void InsBack(Lista& L, habilidad hab)
{
	if (L == NULL)
	{
		L = new nodoHab;
		L->info = hab;
		L->sig = NULL;
	}
	else
		InsBack(L->sig, hab);
}

void contHab(Lista L,int &contNat,int &contPocoNat,int &contSobreNat){
    if (L != NULL){
        switch(darTipoHab(L->info)){

        case natural:
            contNat++;
            break;
        case pocoNatural:
            contPocoNat++;
            break;
        case sobreNatural:
            contSobreNat++;
            break;
        }
        contHab(L->sig, contNat, contPocoNat, contSobreNat);
    }

}

int cantHabEntreFecha(Lista L,date dt1,date dt2){
    int cont = 0;
    while(L != NULL){
         if(postEq(darFchManifestacion(L->info),dt1) && !post(darFchManifestacion(L->info),dt2)){
            cont++;
        }
        L = L->sig;
    }
    return cont;
}

boolean existeHab(Lista L, long int ced){
    if(L != NULL && darCedulaHab(L->info) == ced)
        return TRUE;
    else if(L == NULL && darCedulaHab(L->info) != ced)
        return FALSE;
    else
        return existeHab(L,ced);
}

void MostrarHabFch(Lista L, date fch){
    while (L != NULL) {
        if(sonIguales(fch,darFchManifestacion(L->info)))
            mostrarHab(L->info);
		printf("\n");
		L = L->sig;
	}
}

void Bajar_Lista(Lista L, FILE *f)
{
	while (L != NULL)
	{
		bajarHabilidad(L->info, f);
		L = L->sig;
	}
}
void Levantar_Lista(Lista& L, FILE *f)
{
	habilidad buffer;
	Crear(L);
	levantarHabilidad(buffer, f);
	while (!feof(f))
	{
		InsBack(L, buffer);
		levantarHabilidad(buffer, f);
	}
}
/*
void Bajar_Lista(Lista L, string nomArch)
{
	FILE* f = fopen(nomArch, "wb");
	while (L != NULL)
	{
		bajarHabilidad(L->info, f);
		L = L->sig;
	}
	fclose(f);
}
void Levantar_Lista(Lista& L, string nomArch)
{
	FILE* f = fopen(nomArch, "rb");
	habilidad buffer;
	Crear(L);
	levantarHabilidad(buffer, f);
	while (!feof(f))
	{
		InsBack(L, buffer);
		levantarHabilidad(buffer, f);
	}
	fclose(f);
}
*/
