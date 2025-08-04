using System;


class Pessoa{
    //Atributos - Propriedades da Classe
    public string nome = ""; // Modelo --> acesso / proteção + tipo + nome + inicialização + ; 
    public int idade = 0;

    //Método da Classe

    public void Apresentar(){
        // Console.WriteLine("Olá, meu nome é " + nome + " e tenho " + idade + " anos."); // Alternativa 1
        Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos."); // Alternativa 2
    }
}


class Carro{
    //Atributos

    private string marca = "";

    private string modelo = "";

    private int anoDeFabricacao = 0;

    //Métodos da Classe

    public void Ligar(){
        Console.WriteLine($"{marca} {modelo} de {anoDeFabricacao} está ligado!");
    }

    //Getters / Setters

    public void SetModelo(string newModelo){ //newModelo --> recebido  | modelo --> valor original
        if(newModelo != ""){
            modelo = newModelo;
        }
    }

    public void SetMarca(string newMarca){
        if(newMarca != ""){
            marca = newMarca;
        }
    }

    public void SetAnoDeFabricacao(int newAnoDeFabricacao){
        if(newAnoDeFabricacao != 0){
            anoDeFabricacao = newAnoDeFabricacao;
        }
    }
}

class Program{
    static void Main(string[] args){ //static = único | Main --> roda o programa |  //Funções precisam de ()
        /*Pessoa pessoa_1 = new Pessoa();
            pessoa_1.nome = "Victor";
            pessoa_1.idade = 21;

            pessoa_1.Apresentar();
        */

        Carro carro_1 = new Carro();
            carro_1.SetModelo("Corolla");
            carro_1.SetMarca("Toyota");
            carro_1.SetAnoDeFabricacao(2016);

            carro_1.Ligar();
    }
}
