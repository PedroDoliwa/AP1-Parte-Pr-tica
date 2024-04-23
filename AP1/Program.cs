double altura; // declaraçao de variaveis 
double peso;
int idade;
string  nome;
double imc;
string resultadoImc = "";
string resultadoIdade = "";
string novoRelatorio = "";



do{     // inicio do loop

Console.WriteLine("Qual o seu nome: ");     // perguntas para o usuario
nome = Console.ReadLine();                  // a resposta é gravada na variavel 
Console.WriteLine("Qual sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qual sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual seu peso em KG: ");
peso = Convert.ToDouble(Console.ReadLine());

imc = (float)peso / (altura * altura);    // calculo do IMC 

if(imc<18.5)               // inicio do verificacao do IMC, caso nao corresponda avança para o proximo
{

    resultadoImc = "Abaixo do Peso";
}
else if(imc >= 18.5 && imc <= 24.9)
    {
         resultadoImc = "Peso Normal";
    }
else if(imc >= 25 && imc <= 29.9)
    {
         resultadoImc = "Sobrepeso (acima do peso desejado)";
    }
else
    {
     resultadoImc = "Obesidade";
    }


if(idade<10){                    // inicio do verificacao da Faixa Etaria de Idade, caso nao corresponda avança para o proximo
    resultadoIdade = "Criança";
}
else if(idade>=10 && idade<20)
{
    resultadoIdade ="Adolescente";
}
else if(idade>=20 && idade<60)
{
    resultadoIdade ="Adulto";
}
else
{
    resultadoIdade ="Idoso";
}


Console.WriteLine($"Relatório: \n Nome: {nome} \n Idade: {idade} \n IMC: {resultadoImc} \n Faixa Etaria: {resultadoIdade} " );  // Relatorio finalizado com suas variaveis 

Console.WriteLine("Gostaria de gerar um novo relatorio? (sim/nao)");  // pergunta ao usuario se deseja gerar um novo relatorio para que o loop inicie, caso contrario ele finaliza 
novoRelatorio = Console.ReadLine();


}while(novoRelatorio == "sim");         // finalizaçao do loop e fim do codigo