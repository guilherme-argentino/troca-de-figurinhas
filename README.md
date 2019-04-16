# Troca de figurinhas

## Começando

Usei as seguintes ferramentas para desenvolver este projeto:

- Visual Studio Code
  - com diversas extensões
- Homebrew pois estou usando o Mac
- SQL Lite Browser
- dotNet Core SDK
- Node e Npm

## Comandos iniciais

Inclusão de um template de projeto para usar Vue

```
$ dotnet new -i Microsoft.AspNetCore.SpaTemplates::*
```

Criação do projeto básico

```
$ dotnet new vue -o troca-de-figurinhas
$ cd troca-de-figurinhas/
$ npm install
```

Executando pela primeira vez

```
$ dotnet build
$ dotnet run
```

Como o projeto pode ter problemas de segurança, fiz uma varredura de segurança e atualizei os patchs de segurança

```
$ npm audit fix
```

## Comandos usados durante o desenvolvimento

Ativação do SQLite

```
$ dotnet add package Microsoft.EntityFrameworkCore.Sqlite
$ dotnet add package Microsoft.EntityFrameworkCore.Design
```

Criação do banco de dados e *Migration* inicial:

```
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```