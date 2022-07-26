#include "parsingMod.h"

comando strToCom(string str)
{
	comando com = null;
	string Concat = new char[7], Create = new char[7], Exit = new char[5], InsBack = new char[8], Load = new char[5], Reverse = new char[8], Save = new char[5], Show = new char[5], Sum = new char[4];
	Concat[0] = 'c', Concat[1] = 'o', Concat[2] = 'n', Concat[3] = 'c', Concat[4] = 'a', Concat[5] = 't', Concat[6] = '\0';
	Create[0] = 'c', Create[1] = 'r', Create[2] = 'e', Create[3] = 'a', Create[4] = 't', Create[5] = 'e', Create[6] = '\0';
	Exit[0] = 'e', Exit[1] = 'x', Exit[2] = 'i', Exit[3] = 't', Exit[4] = '\0';
	InsBack[0] = 'i', InsBack[1] = 'n', InsBack[2] = 's', InsBack[3] = 'b', InsBack[4] = 'a', InsBack[5] = 'c', InsBack[6] = 'k', InsBack[7] = '\0';
	Load[0] = 'l', Load[1] = 'o', Load[2] = 'a', Load[3] = 'd', Load[4] = '\0';
	Reverse[0] = 'r', Reverse[1] = 'e', Reverse[2] = 'v', Reverse[3] = 'e', Reverse[4] = 'r', Reverse[5] = 's', Reverse[6] = 'e', Reverse[7] = '\0';
	Save[0] = 's', Save[1] = 'a', Save[2] = 'v', Save[3] = 'e', Save[4] = '\0';
	Show[0] = 's', Show[1] = 'h', Show[2] = 'o', Show[3] = 'w', Show[4] = '\0';
	Sum[0] = 's', Sum[1] = 'u', Sum[2] = 'm', Sum[3] = '\0';
	switch (str[0])
	{
	case 'c':
		if (strEq(str, Concat))
			com = concat;
		else if (strEq(str, Create))
			com = create;
		else
			printf("Error: El comando ingresado no existe.\n");
		break;
	case 'e':
		if (strEq(str, Exit))
			com = exit;
		else
			printf("Error: El comando ingresado no existe.\n");
		break;
	case 'i':
		if (strEq(str, InsBack))
			com = insback;
		else
			printf("Error: El comando ingresado no existe.\n");
		break;
	case 'l':
		if (strEq(str, Load))
			com = load;
		else
			printf("Error: El comando ingresado no existe.\n");
		break;
	case 'r':
		if (strEq(str, Reverse))
			com = reverse;
		else
			printf("Error: El comando ingresado no existe.\n");
		break;
	case 's':
		if (strEq(str, Save))
			com = save;
		else if (strEq(str, Show))
			com = show;
		else if (strEq(str, Sum))
			com = sum;
		else
			printf("Error: El comando ingresado no existe.\n");
		break;
	default:
		printf("Error: El comando ingresado no existe.\n");
		break;
	}

	strDestruir(Concat);
	strDestruir(Create);
	strDestruir(Exit);
	strDestruir(InsBack);
	strDestruir(Load);
	strDestruir(Reverse);
	strDestruir(Save);
	strDestruir(Show);
	strDestruir(Sum);
	return com;
}

void parsing()
{
	comando com;
	string strCom;
	ListaCom lstCom;
	ListaNum lstNum;
	Arbol abbSec;
	strCrear(strCom);
	lstComCrear(lstCom);
	lstCrear(lstNum);
	CrearAbb(abbSec);

	do
	{
		printf("Ingrese comando: ");
		strScan(strCom);
		strSeparar(strCom, lstCom);
		com = strToCom(lstCom->info);

		switch (com)
		{
		case create:
			comCreate(lstCom, abbSec);
			break;
		case insback:
			comInsBack(lstCom, abbSec);
			break;
		case show:
			comShow(lstCom, abbSec);
			break;
		case sum:
			comSum(lstCom, abbSec);
			break;
		case concat:
			comConcat(lstCom, abbSec);
			break;
		case reverse:
			comReverse(lstCom, abbSec);
			break;
		case save:
			comSave(lstCom, abbSec);
			break;
		case load:
			comLoad(lstCom, abbSec);
			break;
		case exit:
			deleteAbb(abbSec);
			printf("Resultado: se eliminaron los espacios en memoria");
			break;
		}
		lstDelete(lstCom);
	} while (com != exit);
	printf("\n");
}

void comCreate(ListaCom lstCom, Arbol& a)
{
	Sec secu;
	ListaCom id = lstCom->sig;
	secCrear(secu, id->info);
	if (contParametros(lstCom) != 2)
		printf("Error: cantidad de parametros invalida.");
	else if (!strEsAlfabetico(id->info))
		printf("Error: el identificador debe ser puramente alfabetico.");
	else if (existeSec(a, id->info))
		printf("Error: ya existe una secuencia con ese identificador.");
	else
	{
		secCrear(secu, id->info);
		Insert(a, secu);
		printf("Resultado: ");
		secMostrar(secu);
	}
	printf("\n");
}

void comInsBack(ListaCom lstCom, Arbol& a)
{
	Arbol secu;
	ListaCom id;
	CrearAbb(secu);
	int valorInt;
	id = lstCom->sig;
	if (contParametros(lstCom) != 3)
		printf("Error: cantidad de parametros invalida.");
	else if (!strEsAlfabetico(id->info))
		printf("Error: el identificador debe ser puramente alfabetico.");
	else if (!strEsNumerico(id->sig->info))
		printf("Error: el valor debe ser un numero entero.");
	else if (!existeSec(a, id->info))
		printf("Error: no existe una secuencia con ese identificador.");
	else
	{
		secu = darPuntSec(id->info, a);
		valorInt = strToInt(id->sig->info);
		insBackNum(secu->info.Nums, valorInt);
		printf("Resultado: ");
		secMostrar(secu->info);
	}
	printf("\n");
}

void comShow(ListaCom lstCom, Arbol& a)
{
	if (contParametros(lstCom) != 1)
		printf("Error: cantidad de parametros invalida.");
	else if (EsVacio(a))
		printf("Error: no hay ninguna secuencia creada.");
	else
	{
		printf("Resultado:\n");
		Orden(a);
	}
}

void comSum(ListaCom lstCom, Arbol& a)
{
	int suma;
	Sec secu;
	ListaCom id = lstCom->sig;
	if (contParametros(lstCom) != 2)
		printf("Error: cantidad de parametros invalida.");
	else if (!strEsAlfabetico(id->info))
		printf("Error: el identificador debe ser puramente alfabetico.");
	else if (!existeSec(a, id->info))
		printf("Error: no existe una secuencia con ese identificador.");
	else
	{
		secu = darSec(id->info, a);
		suma = lstSumar(secu.Nums);
		printf("Resultado: %i", suma);
	}
	printf("\n");
}

void comConcat(ListaCom lstCom, Arbol& a)
{	
	Sec secu1, secu2, secu3;

	if (contParametros(lstCom) == 4) {
		ListaCom id1 = lstCom->sig, id2 = id1->sig, id3 = id2->sig;
		if (!strEsAlfabetico(id1->info) || !strEsAlfabetico(id2->info) || !strEsAlfabetico(id3->info))
			printf("Error: los identificadores deben ser puramente alfabeticos.");
		else if (!existeSec(a, id1->info))
			printf("Error: no existe una secuencia con el primer identificador.");
		else if (!existeSec(a, id2->info))
			printf("Error: no existe una secuencia con el segundo identificador.");
		else if (existeSec(a, id3->info))
			printf("Error: ya existe una secuencia con el tercer identificador.");
		else
		{
			secu1 = darSec(id1->info, a);
			secu2 = darSec(id2->info, a);
			secCrear(secu3, id3->info);
			lstConcatenar(secu1.Nums, secu2.Nums, secu3.Nums);
			Insert(a, secu3);
			printf("Resultado: ");
			secMostrar(secu3);
		}
	}
	else
		printf("Error: cantidad de parametros invalida.");
		
	printf("\n");
}

void comReverse(ListaCom lstCom, Arbol& a)
{
	Sec secu1, secu2;

	if (contParametros(lstCom) == 3) {
		ListaCom id1 = lstCom->sig, id2 = id1->sig;
		if (!strEsAlfabetico(id1->info) || !strEsAlfabetico(id2->info))
			printf("Error: los identificadores deben ser puramente alfabeticos.");
		else if (!existeSec(a, id1->info))
			printf("Error: no existe una secuencia con el primer identificador.");
		else if (existeSec(a, id2->info))
			printf("Error: ya existe una secuencia con el segundo identificador.");
		else
		{
			secu1 = darSec(id1->info, a);
			secCrear(secu2, id2->info);
			lstInvertir(secu1.Nums, secu2.Nums);
			Insert(a, secu2);
			printf("Resultado: ");
			secMostrar(secu2);
		}
	}
	else
		printf("Error: cantidad de parametros invalida.");

	printf("\n");
}

void comSave(ListaCom lstCom, Arbol& a)
{
	Sec secu;
	if (contParametros(lstCom) == 3) {
		ListaCom id1 = lstCom->sig, nomArch = id1->sig;
		if (!strEsAlfabetico(id1->info) || !strEsAlfabetico(nomArch->info))
			printf("Error: los identificadores deben ser puramente alfabeticos.");
		else if (!validarNomArch(nomArch->info))
			printf("Error: el nombre del archivo debe tener la extencion '.txt'.");
		else if (!existeSec(a, id1->info))
			printf("Error: no existe una secuencia con el primer identificador.");
		else
		{
			secu = darSec(id1->info, a);
			Bajar_Sec(secu, nomArch->info);
			printf("Resultado: la secuencia se guardo en disco exitosamente");
		}
	}
	else
		printf("Error: cantidad de parametros invalida.");

	printf("\n");
}

void comLoad(ListaCom lstCom, Arbol& a)
{
	Sec secu;
	if (contParametros(lstCom) == 3) {
		ListaCom nomArch = lstCom->sig, id1 = nomArch->sig;
		if (!strEsAlfabetico(id1->info) || !strEsAlfabetico(nomArch->info))
			printf("Error: los identificadores deben ser puramente alfabeticos.");
		else if (!validarNomArch(nomArch->info))
			printf("Error: el nombre del archivo debe tener la extencion '.txt'.");
		else if (!existeArch(nomArch->info))
			printf("Error: no existe un archivo con ese nombre.");
		else if (existeSec(a, id1->info))
			printf("Error: ya existe una secuencia con el primer identificador.");
		else
		{
			secCrear(secu, id1->info);
			Levantar_Sec(secu, nomArch->info);
			secu.ident = id1->info;
			Insert(a, secu);
			printf("Resultado: ");
			secMostrar(secu);
		}
	}
	else
		printf("Error: cantidad de parametros invalida.");

	printf("\n");
}