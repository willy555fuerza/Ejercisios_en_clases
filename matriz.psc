Proceso matriz
	Definir vec,f,c,n,w Como Entero;
	Dimension vec[100,100];
	Escribir 'ingresar la dimension del vector';
	Leer w;
	Escribir 'ingresar la dimension del vector';
	Leer n;
	Para f<-0 Hasta w-1 Hacer
		Para c<-0 Hasta n-1 Hacer
//			Leer vec[f,c];
			vec[f,c]<-azar[100];
		FinPara
	FinPara
	Para f<-0 Hasta w-1 Hacer
		Para c<-0 Hasta n-1 Hacer
			Escribir '[',vec[f,c],']' Sin Saltar;
		FinPara
		Escribir '';
	FinPara
FinProceso
