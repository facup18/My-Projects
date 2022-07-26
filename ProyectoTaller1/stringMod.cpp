#include "stringMod.h"

void strCrear(string& s)
{
	s = new char[1];
	s[0] = '\0';
}
void strDestruir(string& s)
{
	delete[] s;
	s = NULL;
}
int strLar(string s)
{
	int i = 0;
	while (s[i] != '\0')
		i++;
	return i;
}
void strCop(string& s1, string s2)
{
	int i = 0;
	int largo = strLar(s2) + 1;
	delete[] s1;
	s1 = new char[largo];
	while (s2[i] != '\0')
	{
		s1[i] = s2[i];
		i++;
	}
	s1[i] = '\0';
}
void strScan(string& s)
{
	string aux = new char[MAX];
	int i = 0;
	char c;
	scanf(" %c", &c);
	while ((c != '\n' && i < MAX - 1))
	{
		aux[i] = c;
		i++;
		scanf("%c", &c);
	}
	aux[i] = '\0';
	strCop(s, aux);
	strDestruir(aux);
}

void strPrint(string s)
{
	int i = 0;
	while (s[i] != '\0')
	{
		printf("%c", s[i]);
		i++;
	}
}


boolean strEq(string s1, string s2)
{
	int i = 0;
	boolean iguales = TRUE;
	while (iguales && (s1[i] != '\0') && (s2[i] != '\0'))
	{
		if (s1[i] != s2[i])
			iguales = FALSE;
		i++;
	}
	if ((s1[i] != '\0') || (s2[i] != '\0'))
		iguales = FALSE;
	return iguales;
}

boolean strmen(string s1, string s2)
{
	int i = 0;
	boolean encontre = FALSE;
	boolean menor = FALSE;
	while ((!encontre) && (s1[i] != '\0') && (s2[i] != '\0'))
	{
		if (s1[i] != s2[i])
			encontre = TRUE;
		if (s1[i] < s2[i])
			menor = TRUE;
		i++;
	}
	if ((!encontre) && (s2[i] != '\0'))
		menor = TRUE;
	return menor;
}

boolean strEsAlfabetico(string s)
{
	boolean esAlf = TRUE;
	int i = 0;
	while (s[i] != '\0' && esAlf == TRUE) {
		if (!((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z') || s[i] == '.'))
			esAlf = FALSE;
		i++;
	}
	return esAlf;
}

boolean strEsNumerico(string s)
{
	boolean esNum = TRUE;
	int i = 0;
	while (s[i] != '\0' && esNum == TRUE) {
		if (!(s[i] >= '0' && s[i] <= '9'))
			esNum = FALSE;
		i++;
	}
	return esNum;
}

boolean validarNomArch(string s)
{
	int i = 0;
	boolean esValido = FALSE;
	do
	{
		if (s[i] == '.' && s[i + 1] == 't' && s[i + 2] == 'x' && s[i + 3] == 't' && s[i + 4] == '\0')
			esValido = TRUE;
		i++;
	} while (s[i + 3] != '\0');
	return esValido;
}

int strToInt(string s)
{
	int i = 0, num, sum = 0;
	do
	{
		sum *= 10;
		num = s[i] - 48;
		sum += num;

		i++;
	} while (s[i] != '\0');
	return sum;
}

int strContPalabras(string s) {
	int i = 0,cont = 0;
	while (s[i] != '\0')
	{
		if ((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z')) {
			cont++;
			do {
				i++;
			}while (s[i] != ' ' && s[i] != '\0');
		}

		if (s[i] != '\0')
			i++;

	}
	return cont;
}

void Bajar_String(string s, FILE* f)
{
	int i = 0;
	while (s[i] != '\0')
	{
		fwrite(&s[i], sizeof(char), 1, f);
		i++;
	}
	fwrite(&s[i], sizeof(char), 1, f);
}

void Levantar_String(string& s, FILE* f)
{
	int i = 0;
	string aux;
	aux = new char[MAX];
	strCrear(s);
	fread(&aux[i], sizeof(char), 1, f);
	while (!feof(f) && (aux[i] != '\0'))
	{
		i++;
		fread(&aux[i], sizeof(char), 1, f);
	}
	strCop(s, aux);
	delete[] aux;
}