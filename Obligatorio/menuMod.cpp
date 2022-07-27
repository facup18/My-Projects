#include "menuMod.h"

const string = "socios.txt";

void menu(){
    registrarDatos();
    listarDatos();
    consultarDatos();
}

void registrarDatos(){
    int op;
    socio soc;
    habilidad hab;
    while(op == 0){
        printf("1-Registrar Socio\n2-Registrar habilidad\n3-Salir");
        scanf("%i",&op);
        switch(op){
        case 1:
            cargarSocio(soc);
            registrarSocio(soc);
            break;
        case 2:
            cargarHab(hab);
            registrarHabilidad(hab);
            break;
        case 3:
            printf("Ha salido correctamente.");
            break;
        default:
            printf("\nOpcion ingresada no válida!");
            op = 0;
            break;
        }
    }
}

void registrarSocio(socio soc){
    Arbol a;
    FILE *f;
    f = fopen("socios.txt","rb");
    Levantar_ABB(a,f);
    fclose(f);
    Insert(a,soc);
    f = fopen("socios.txt","wb");
    Bajar_ABB(a,f);
    fclose(f);
}

void registrarHabilidad(habilidad hab){
    Lista L;
    FILE *f;
    f = fopen("habilidades.txt","rb");
    Levantar_Lista(L,f);
    fclose(f);
    InsFront(L,hab);
    f = fopen("habilidades.txt","wb");
    Bajar_Lista(L,f);
    fclose(f);
}
