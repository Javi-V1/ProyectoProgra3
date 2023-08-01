using Capa_Logica.Cola;
using Capa_Logica.Lista_Doble;
using Capa_Logica.Lista_Simple;
using Capa_Logica.Pila;

//Orquestador_Lista_Simple orquestador_LS = new Orquestador_Lista_Simple();
Orquestador_Lista_Doble orquestador_LD = new Orquestador_Lista_Doble();
//Orquestador_Cola orquestador_Cola   = new Orquestador_Cola();
//Orquestador_Pila orquestador_Pila = new Orquestador_Pila();

//orquestador_LS.Ejercicio1_LS();
orquestador_LD.Ejercicio2_LD();

/*Random random = new Random();
int numero = random.Next(0, 11);

int resultadoUnidades;
int resultadoDecenas;
int resultadoCentenas;

resultadoCentenas = numero / 100; //esto me va a dar como resultado el numero en los centenares
resultadoDecenas = numero % 100 / 10; //esto me va a dar como resultado el numero en los decenares
resultadoUnidades = numero % 100 % 10; //esto me va a dar como resultado el numero en las unidades

Console.WriteLine(numero + " centenas: " + resultadoCentenas + " decenas: " + resultadoDecenas + " unidades: " + resultadoUnidades);*/
