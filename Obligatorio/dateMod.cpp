#include "dateMod.h"

void loadDate(date& dte) {
    do
    {
        printf("\nIngrese Dia: ");
        setDay(dte);

        printf("\nIngrese Mes: ");
        setMonth(dte);

        printf("\nIngrese Año: ");
        setYear(dte);

        if (!valDate(dte))
        {
            printf("\nFecha invalida, por favor ingrese la fecha de nuevo.");
        }
    } while (!valDate(dte));
}

void printDate(date dte) {
    printf("%i / %i / %i", getDay(dte), getMonth(dte), getYear(dte));
}



int getDay(date dte) {
    return dte.day;
}


int getMonth(date dte) {
    return dte.month;
}


int getYear(date dte) {
    return dte.year;
}


void setDay(date& dte)
{
    scanf("%i", &dte.day);
}

void setMonth(date& dte)
{
    scanf("%i", &dte.month);
}

void setYear(date& dte)
{
    scanf("%i", &dte.year);
}


boolean valDate(date dte) {
    boolean val = FALSE;
    if (getYear(dte) >= 0) {
        switch (getMonth(dte)) {
        case 1:case 3: case 5: case 7: case 8: case 10: case 12:
            if (getDay(dte) > 0 && getDay(dte) <= 31)
                val = TRUE;
            break;

        case 2:
            if (getYear(dte) % 4 == 0 && getDay(dte) > 0 && getDay(dte) <= 29)
                val = TRUE;
            else if (getYear(dte) % 4 != 0 && getDay(dte) > 0 && getDay(dte) <= 28)
                val = TRUE;
            break;

        case 4: case 6: case 9: case 11:
            if (getDay(dte) > 0 && getDay(dte) <= 30)
                val = TRUE;
            break;

        default:

            break;
        }
    }
    return val;
}

boolean postEq(date dte1, date dte2)
{
    boolean post = TRUE;
    if (getYear(dte1) < getYear(dte2))
        post = FALSE;
    else if (getYear(dte1) == getYear(dte2) && getMonth(dte1) < getMonth(dte2))
        post = FALSE;
    else if (getYear(dte1) == getYear(dte2) && getMonth(dte1) == getMonth(dte2) && getDay(dte1) < getDay(dte2))
        post = FALSE;

    return post;
}

boolean post(date dte1, date dte2)
{
    boolean post = TRUE;
    if (getYear(dte1) <= getYear(dte2))
        post = FALSE;
    else if (getYear(dte1) == getYear(dte2) && getMonth(dte1) <= getMonth(dte2))
        post = FALSE;
    else if (getYear(dte1) == getYear(dte2) && getMonth(dte1) == getMonth(dte2) && getDay(dte1) <= getDay(dte2))
        post = FALSE;

    return post;
}

boolean sonIguales(date dte1, date dte2){
    boolean iguales = FALSE;
    if(getYear(dte1) == getYear(dte2) && getMonth(dte1) == getMonth(dte2) && getDay(dte1) == getDay(dte2))
        iguales = TRUE;
    return iguales;
}

void bajarFecha(date dte, FILE* f)
{
    fwrite(&dte.day, sizeof(int), 1, f);
    fwrite(&dte.month, sizeof(int), 1, f);
    fwrite(&dte.year, sizeof(int), 1, f);
}

void levantarFecha(date& dte, FILE* f)
{
    fread(&dte.day, sizeof(int), 1, f);
    fread(&dte.month, sizeof(int), 1, f);
    fread(&dte.year, sizeof(int), 1, f);
}
