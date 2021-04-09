# Tarea 3 (Tarea de repaso)

Esta tarea cuenta de dos Asignaciones:


##Asignación 1

Escriba la definición de la clase CuentaBancaria cuyo alcance debe ser público. Tipos:

public string TitularCta;
public string cuit;
public decimal saldo;
public int numeroCBU;

Cree 2 instancias de la clase CuentaBancaria con los siguientes valores, respetando la definición de creación de la clase del punto anterior:

Instancia 1:
	titularCta: "Juan Alonso"
	cuit: "20-26987456-7"
	saldo: 1258.75
	numeroCBU: 1236547896554

Instancia 2:
	titularCta: “Alberto Lopez” 
	cuit: “23-15654321-9” 
	saldo: 25698.78 
	numeroCBU: 9876546546557



##Asignación 2

Un banco tiene 3 clientes que pueden hacer depósitos y extracciones. También el banco requiere que al final del día calcule la cantidad de dinero que hay depositada.


La Solución tendrá el siguiente esquema: Debemos definir los atributos y los métodos de cada clase:

Cliente
    atributos
        nombre
        monto
    métodos
        constructor
        Depositar
        Extraer
        RetornarMonto

Banco
    atributos
        3 Cliente (3 objetos de la clase Cliente)
    métodos
        constructor
        Operar
        DepositosTotales







**Forma de entrega: GitHub**

**Valor: 15 Puntos**

