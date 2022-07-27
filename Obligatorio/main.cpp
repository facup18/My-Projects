#include "menuMod.h"

int main()
{
    /*Lista lHab;
    lHab = NULL;//Crear(lHab);
    habilidad hab;
    date dt1,dt2;
    cargarHab(hab);
    InsFront(lHab, hab);

    cargarHab(hab);
    InsFront(lHab, hab);

    cargarHab(hab);
    InsFront(lHab, hab);
    loadDate(dt1);
    loadDate(dt2);

    printf("Cantidad de habilidades entre fechas:%i\n",cantHabEntreFecha(lHab,dt1,dt2));*/

    date dte;
    socio soc, aux;
    Arbol a;
    int x = 0,y = 0,z = 0;
    CrearAbb(a);

    cargarSocio(soc);
    Insert(a,soc);

    cargarSocio(soc);
    Insert(a,soc);

    cargarSocio(soc);
    Insert(a,soc);

    Orden(a);

    /*contSociosCat(a,x,y,z);
    printf("Cantidad de Hadas:%i\nCantidad de Brujos:%i\nCantidad de Hechiceros:%i\n",x,y,z);
    x = 0,y = 0,z = 0;*/

}
