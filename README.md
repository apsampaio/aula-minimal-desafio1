## Comando de Criação de Minimal API

```cmd
dotnet new web -o AppName
```

## Comando para Build e Inicialização do Projeto

```cmd
dotnet run
```

## Comando para Build e Inicialização do Projeto com Hot Reload

```cmd
dotnet watch run
```

## Comando para Adicionar Pacotes ao Projeto

```cmd
dotnet add package NomeDoPacote
```

## Comando para Adicionar Migrations Mais Recentes do Banco de Dados

```cmd
dotnet ef migration add NomeDaMigration --output-dir ./Infra/Migrations
```

## Comando para Atualizar Diferenças do Banco de Dados

```cmd
dotnet ef database update
```
