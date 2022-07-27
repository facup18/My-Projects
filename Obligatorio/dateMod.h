#ifndef dateMod
#define dateMod
#include "booleanMod.h"

typedef struct {
    int day, month, year;
}date;

/*Carga la fecha <dte>.*/
void loadDate(date& dte);

/*Despliega en pantalla la fecha <dte>.*/
void printDate(date dte);


/*Devuelve el dia de la fecha <dte>.*/
int getDay(date dte);

/*Devuelve el mes de la fecha <dte>.*/
int getMonth(date dte);

/*Devuelve el año de la fecha <dte>.*/
int getYear(date dte);


/*Establece el valor <day> de <dte>.*/
void setDay(date& dte);

/*Establece el valor <month> de <dte>.*/
void setMonth(date& dte);

/*Establece el valor <year> de <dte>.*/
void setYear(date& dte);


/*Devuelve FALSE en caso de que la fecha no sea valida y TRUE en caso contrario.*/
boolean valDate(date dte);

/*Devuelve TRUE en caso de que dte1 en caso de que sea posterior a dte2 y FALSE en caso contrario*/
boolean postEq(date dte1, date dte2);

boolean post(date dte1, date dte2);

boolean sonIguales(date dte1, date dte2);

/*Escribe en el archivo los datos de date dte.
Precondicion: El archivo viene abierto para escritura.*/
void bajarFecha(date dte, FILE* f);

/*Lee desde el archivo los datos de date dte.
Precondicion: El archivo viene abierto para escritura.*/
void levantarFecha(date &dte, FILE* f);

#endif // fecha
