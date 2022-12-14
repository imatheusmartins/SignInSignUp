# Sistema Sign in/Sign up, processo seletivo Everymind.

## Introdução

Este é um projeto no qual, a empresa fictícia chamada Oliveira Trade, solicitou uma forma de sign in e sign up de usuários, utilizando os campos básico para cadastro de pessoas físicas.

## Tecnologias utilizadas

* [C#/Windows Forms.NET](https://learn.microsoft.com/pt-br/dotnet/desktop/winforms/?view=netdesktop-6.0): C# é uma linguagem de programação orientada a objeto, multiparadigma criada pela Microsoft / Windows Forms .NET é uma tecnologia de interface do usuário para .NET, é possivel criar, de uma forma bem ágil, aplicativos da área de trabalho com base no designer visual fornecido no Visual Studio.
* [Microsoft SQL Server Management Studio 18](https://learn.microsoft.com/en-us/sql/ssms/sql-server-management-studio-ssms?view=sql-server-ver16): ambiente integrado para gerenciar qualquer infraestrutura SQL.

## Instruções para executar o código:
O projeto foi desenvolvido aplicando o modelo de arquitetura de três camadas, onde temos a camada de interface do usuário, a camada do aplicativo, onde os dados são processados (também faz a comunicação entre a camada de interface e a camada de dados) e por fim, a camada de dados, em que os dados associados ao aplicativo são armazenados e gerenciados (SQl Server).

Neste projeto, foi criado um server local para o armazenamento dos dados do usuário, por conta disso, para fazer o uso deste código, é necessário que você crie um banco de dados e uma tabela com os mesmo requisitos pedidos no cadastro de usuários, dentro do SQL Server. Com isto feito, basta conectar o projeto que está dentro do Visual Studio ao banco de dados.

Segue o link de um vídeo no YouTube, do canal Miriam TechCode, onde são passados os detalhes de como conectar um projeto em C# a um banco de dados SQL: https://youtu.be/HihxWOXxFic


