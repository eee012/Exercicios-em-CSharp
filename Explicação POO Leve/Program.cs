using Explicação_POO_Leve;
using System.Data.Common;

//POO
//Heranca - Uma classe derivada de uma superclasse (Atributos, Metodos)
//Abstracao - Isolar somente as informacoes mais relevantes
//Polimorfismo - Muitas formas de executar um determinado metodo. Escrito/Reescrito diversas vezes.
//Encapsulamento - Como os atributos podem ser acessados/vistos {get; set;}

//1. Classes 
//Um plano, capsula, teoria, modelo, molde

//2. Objeto
//Instancia de uma classe.
//feita com new

//3. Atributos e Metodos 
//Atributos - caracteristicas do objeto - variaveis que guardam informacoes de um objeto 
//Metdo - sao funcoes que determinam os comportamentos do objeto.

//COMO CRIAR UM OBJETO?
//CRIAR INSTANCIA VALOR CARRO. + outras

Moto moto = new Moto();
Carro carro01 = new Carro();

carro01.modelo = "Argo";
carro01.marca = "FIAT";
carro01.valor = 123000;
carro01.ano = 2026;
carro01.cor = "Vermelho";

carro01.ExibirDetalhes();

moto.marca = "Suzuki";
moto.modelo = "Hayabusa";
moto.ano = 2020;
moto.valor = 50000;
moto.cor = "Branca";
moto.temPartidaEletrica = true;

moto.ExibirDetalhes();


//Localização do Chamador	                   public protected internal private
//Dentro da própria classe	                    ✔️	  ✔️   	    ✔️	     ✔️
//Classe derivada (Mesmo Assembly)	            ✔️	  ✔️     	✔️	     ❌
//Classe não derivada (Mesmo Assembly)	        ✔️	  ❌	    ✔️	     ❌
//Classe derivada (Assembly diferente)	        ✔️	  ✔️     	❌     	 ❌
//Classe não derivada (Assembly diferente)	    ✔️	  ❌	    ❌	     ❌

