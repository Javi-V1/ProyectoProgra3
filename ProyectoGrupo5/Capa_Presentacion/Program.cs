using Capa_Logica.Cola;
using Capa_Logica.Lista_Doble;
using Capa_Logica.Lista_Simple;

Orquestador_Lista_Simple orquestador_LS = new Orquestador_Lista_Simple();
Orquestador_Lista_Doble orquestador_LD = new Orquestador_Lista_Doble();
Orquestador_Cola orquestador_Cola   = new Orquestador_Cola();



//LISTA SIMPLE
//Busque_Numero_Maximo_Lista()
/*
orquestador_LS.Agregar_NodoInt_LS(1);
orquestador_LS.Agregar_NodoInt_LS(5);
orquestador_LS.Agregar_NodoInt_LS(3);
orquestador_LS.Agregar_NodoInt_LS(4);
Console.WriteLine(orquestador_LS.Busque_Numero_Maximo_Lista());
*/

//Busque_Numero_Maximo_Lista()
/*
orquestador_LS.Agregar_NodoInt_LS(-1);
orquestador_LS.Agregar_NodoInt_LS(5);
orquestador_LS.Agregar_NodoInt_LS(3);
orquestador_LS.Agregar_NodoInt_LS(4);
Console.WriteLine(orquestador_LS.Busque_Numero_Minimo_Lista());
*/

//Sume_Elementos_Lista()
/*
orquestador_LS.Agregar_NodoInt_LS(1);
orquestador_LS.Agregar_NodoInt_LS(2);
orquestador_LS.Agregar_NodoInt_LS(3);
orquestador_LS.Agregar_NodoInt_LS(4);
Console.WriteLine(orquestador_LS.Sume_Elementos_Lista());
*/
//Verifique_Todos_Elementos_Pares()
/*
orquestador_LS.Agregar_NodoInt_LS(0);
orquestador_LS.Agregar_NodoInt_LS(2);
orquestador_LS.Agregar_NodoInt_LS(4);
orquestador_LS.Agregar_NodoInt_LS(6);
Console.WriteLine(orquestador_LS.Verifique_Todos_Elementos_Pares());
*/

//LISTA DOBLE
//Sume_Izquierda_Pares_Reste_Derecha_Impares()
/*
orquestador_LD.Agregue_NodoInt_LD_Final(2);
orquestador_LD.Agregue_NodoInt_LD_Final(2);
orquestador_LD.Agregue_NodoInt_LD_Final(2);
orquestador_LD.Agregue_NodoInt_LD_Final(5);
Console.WriteLine(orquestador_LD.Sume_Izquierda_Pares_Reste_Derecha_Impares());
*/

//Verifique_Nodo_Anterior_Con_Valor()
/*
orquestador_LD.Agregue_NodoInt_LD_Final(1);
orquestador_LD.Agregue_NodoInt_LD_Final(2);
orquestador_LD.Muestre_Lista_Inicio_Fin();
orquestador_LD.Muestre_Lista_Fin_Inicio();
Console.WriteLine(orquestador_LD.Verifique_Nodo_Anterior_Con_Valor(2,1));
*/

//Agregue_Nodo_Despues_De_Valor()
/*
orquestador_LD.Agregue_NodoInt_LD_Final(1);
orquestador_LD.Agregue_NodoInt_LD_Final(3);
orquestador_LD.Muestre_Lista_Inicio_Fin();
orquestador_LD.Muestre_Lista_Fin_Inicio();
orquestador_LD.Agregue_Nodo_Despues_De_Valor( 1,2 );
orquestador_LD.Muestre_Lista_Inicio_Fin();
orquestador_LD.Muestre_Lista_Fin_Inicio();
*/

//Elimine_Nodo_Segun_Valor()
/*
orquestador_LD.Agregue_NodoInt_LD_Final(1);
orquestador_LD.Agregue_NodoInt_LD_Final(2);
orquestador_LD.Agregue_NodoInt_LD_Final(3);
orquestador_LD.Muestre_Lista_Inicio_Fin();
orquestador_LD.Muestre_Lista_Fin_Inicio();
orquestador_LD.Elimine_Nodo_Segun_Valor(2);
orquestador_LD.Muestre_Lista_Inicio_Fin();
orquestador_LD.Muestre_Lista_Fin_Inicio();
*/

//
//COLA
//Dequeue_Pares()
/*
orquestador_Cola.Enqueue(1);
orquestador_Cola.Enqueue(2);
orquestador_Cola.Enqueue(3);
orquestador_Cola.Enqueue(4);
orquestador_Cola.Imprimir_Cola();
orquestador_Cola.Dequeue_Pares();
orquestador_Cola.Imprimir_Cola();
*/

//Busque_Valor_En_Cola(int _valor)
/*
orquestador_Cola.Enqueue(1);
orquestador_Cola.Enqueue(2);
orquestador_Cola.Enqueue(3);
orquestador_Cola.Enqueue(4);
orquestador_Cola.Imprimir_Cola();
Console.WriteLine(orquestador_Cola.Busque_Valor_En_Cola(0));
*/

//Dequeue_Mitad_Elementos() 
/*
orquestador_Cola.Enqueue(1);
orquestador_Cola.Enqueue(2);
orquestador_Cola.Enqueue(3);
orquestador_Cola.Enqueue(4);
orquestador_Cola.Enqueue(5);
orquestador_Cola.Imprimir_Cola();
orquestador_Cola.Dequeue_Mitad_Elementos();
orquestador_Cola.Imprimir_Cola();
*/
