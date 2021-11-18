## Sistema de Gestão Hoteleira Hotel Mountain ##
*Este projeto é uma aplicação de gestão de hóteis, especificamente para o Hotel Moutain


## Sobre o Projeto ##

*Aplicação desenvolvida para o PIM do 4ºSemestre do curso de Análise e Desenvolvimento de Sistemas na Universidade Paulista.

*Esta aplicação permite o cadastro de hóspedes.
*Permite o cadastro de funcionários.
*Permite o cadastro de quartos, incluindo suas categorias e seus respectivos valores.
*Permite o cadastro de fornecedores.
*Permite o cadastro de produtos, incluindo valor de compra e venda, categoria do produto e atribuir ele a um fornecedor.
*Permite realizar o processo de Check-In e Check-Out de um hóspede.
*Ao realizar o Check-Out é possível incluir produtos e serviços utilizados pelos hóspedes, acarretando na alteração final do valor.
*Ao realizar o Check-In em um determinado quarto, seu status é alterado para "OCUPADO", evitando vários Check-In em um mesmo quarto. O comboBox lista apenas quartos que estão com o status "DISPONIVEL".


## ATENÇÃO!! - Observações ##
*O banco de dados da aplicação foi hospedada na plataforma somee.com, dispensando a necessidade de criar um banco de dados local, porém de qualquer forma estaremos disponibilizando os scripts sql.
*Caso houver a necessidade de criar o banco localmente, rode primeiro o arquivo "schemaScript". Logo após rode o arquivo "estadosScript", ele possui dados de todos os estados brasileiros, dados utilizados para preencher alguns comboBox.
*Recomendados executar o sistema pela IDE Visual Studio 2019.
*Para realizar o Check-In/Check-Out é necessário o hóspede estar previamente cadastrado.
*Para realizar o Check-In/Check-Out é necessário um quarto estar previamente cadastrado.
*Para realizar o cadastro de um produto é necessário seu fornecedor estar previamente cadastrado.
*Removemos as funções de alteração/exclusão das funcionalidades de Check-In/Check-Out, por conta de problemas de integridade de dados.
*Para realizar o Check-Out é necessário informar o CPF do hóspede que já tenha realizado o Check-In.


## Tecnologias utilizadas ##
*Linguagem C#
*Visual Studio 2019
*SQL Server 2016