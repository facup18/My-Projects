#include "booleanMod.h"

void setBool(boolean &b)
{
	int value;
	printf("\nIngrese 0 si es falso y 1 si es verdadero:\n");
	scanf("%i", &value);
	if (value == 0)
		b = FALSE;
	else
		b = TRUE;
}

void printBool(boolean b)
{
	if (b)
		printf("Verdadero");
	else
		printf("Falso");
} 