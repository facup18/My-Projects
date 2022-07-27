#include "arbolMod.h"
/* crear un �rbol vac�o */
void CrearAbb(Arbol& a)
{
    a = NULL;
}
/* saber si el �rbol est� vac�o */
boolean EsVacio(Arbol a)
{
    return (boolean)(a == NULL);
}
/* devolver la ra�z del �rbol */
/* Precondici�n: Arbol NO vac�o */
socio DarRaiz(Arbol a)
{
    return a->info;
}
/* obtener el sub�rbol izquierdo */
/* Precondici�n: Arbol NO vac�o */
Arbol HijoIzq(Arbol a)
{
    return a->hizq;
}
/* obtener el sub�rbol derecho */
/* Precondici�n: Arbol NO vac�o */
Arbol HijoDer(Arbol a)
{
    return a->hder;
}

/* dados dos �rboles y un valor, devolver un nuevo �rbol
 colocando dicho valor como una nueva ra�z y a los dos
 �rboles como sub�rboles de la misma*/
void Insert(Arbol& a, socio soc)
{
    if (a == NULL && !existeSocio(a,darCedula(soc))) {
        a = new nodo;
        a->info = soc;
        a->hizq = NULL;
        a->hder = NULL;
    }else if(existeSocio(a,darCedula(soc))){
        printf("La cedula coincide con un socio existente (ADVERTENCIA!!:El socio no sera guardado)\n");
    }else{
        if (darCedula(soc) < darCedula(a->info))
            Insert(a->hizq, soc);
        else
            Insert(a->hder, soc);
    }
}

void PreOrden(Arbol a) {

    if (a != NULL) {
        mostrarSocio(a->info);
        PreOrden(a->hizq);
        PreOrden(a->hder);
    }
}

void Orden(Arbol a)
{
    if (a != NULL) {
        Orden(a->hizq);
        mostrarSocio(a->info);
        printf("\n");
        Orden(a->hder);
    }
}

void PostOrden(Arbol a)
{
    if (a != NULL) {
        PostOrden(a->hizq);
        PostOrden(a->hder);
        mostrarSocio(a->info);
    }
}

int ContarNodo(Arbol a)
{
    if (a == NULL)
        return 0;
    else
    {
        return 1 + ContarNodo(a->hizq) + ContarNodo(a->hder);
    }
}
/*
int Maximo(Arbol a)
{
    if (a->hder == NULL)
        return a->info;
    else
        return Maximo(a->hder);
}*/

/*
boolean EsHoja(Arbol a, socio soc)
{
    if (a->info == soc && a->hder == NULL && a->hizq == NULL)
        return TRUE;
    else if (a->info == soc && (a->hder == NULL || a->hizq == NULL))
        return FALSE;
    else
        if (soc < a->info)
            return EsHoja(a->hizq, soc);
        else
            return EsHoja(a->hder, soc);
}*/
/*Precondicion: El numero pertenece al arbol*//*
int Profundidad(Arbol a, socio soc) {

    if (a->info == soc)
        return 1;
    else {
        if (soc < a->info)
            return 1 + Profundidad(a->hizq, soc);
        else
            return 1 + Profundidad(a->hder, soc);
    }
}*/

void Eliminar(Arbol& a)
{
    if (a != NULL)
    {
        Eliminar(a->hizq);
        Eliminar(a->hder);
        delete a;
        a = NULL;
    }
}


boolean existeSocio(Arbol a, long int ced){
    if(a == NULL)
        return FALSE;
    else if(darCedula(a->info) == ced)
        return TRUE;
    else{
        if(ced < darCedula(a->info))
            return existeSocio(a->hizq,ced);
        else
            return existeSocio(a->hder,ced);
    }
}

int contarNacAnterior(Arbol a, date dte)
{
    if (a == NULL)
        return 0;
    else if (post(darFchNacimiento(a->info), dte))
        return 1 + ContarNodo(a->hizq) + ContarNodo(a->hder);
    else
        return ContarNodo(a->hizq) + ContarNodo(a->hder);
}

void contSociosCat(Arbol a,int &contHad,int &contBruj,int &contHech){
    if (a != NULL){
        switch(darCatMagica(a->info)){

        case Brujo:
            contBruj++;
            break;
        case Hechicero:
            contHech++;
            break;
        case Hada:
            contHad++;
            break;
        }
        contSociosCat(a->hizq,contHad,contBruj,contHech);
        contSociosCat(a->hder,contHad,contBruj,contHech);

    }

}


void mostrarSocioSinHab(Arbol a,socio &soc,Lista L){
    if (a != NULL) {
        mostrarSocioSinHab(a->hizq);
        if(!tieneHab(soc,L))
            mostrarSocio(soc);
        printf("\n");
        mostrarSocioSinHab(a->hder);
    }
}

void socioPoderoso(Arbol a,Lista L){
    socio poderoso;
    poderoso = a->info;
    if(socioPoderosoAux())

}

void socioPoderosoAux(Arbol a,Lista L,socio &poderoso){
    if(cantHabSobreNat(poderoso,L) < cantHabSobreNat(a->info,L))
        socioPoderosoAux(a,L,a->info);
    else{
        if()
    }
}

void Bajar_ABB(Arbol a, FILE* f)
{
    if (a != NULL) {
        bajarSocio(a->info, f);
        Bajar_ABB_Aux(a->hizq, f);
        Bajar_ABB_Aux(a->hder, f);
    }
}

/*void Bajar_ABB(Arbol a, string nomArch)
{
    FILE* f;
    f = fopen(nomArch, "wb");
    Bajar_ABB_Aux(a, f);
    fclose(f);
}
*/
void Levantar_ABB(Arbol& a,FILE *f)
{
    socio buffer;
    levantarSocio(buffer, f);
    while (!feof(f)) {
        Insert(a, buffer);
        levantarSocio(buffer, f);
    }
}

/*void Levantar_ABB(Arbol& a, string nomArch)
{
    FILE* f;
    socio buffer;
    f = fopen(nomArch, "rb");
    levantarSocio(buffer, f);
    while (!feof(f)) {
        Insert(a, buffer);
        levantarSocio(buffer, f);
    }
    fclose(f);
}
*/
