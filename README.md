<p align="center">
  <a target="blank"><img src="./.github/LogoAuth.svg" width="320" alt="Auth App" /></a>
</p>

<h3 align="center">
    DeliveryFIT - Autenticação
</h3>

<p align="center">
    <img alt=".NET Core 6" src="https://img.shields.io/badge/-Core 6-512BD4?style=for-the-badge&logo=dotnet&logoColor=white">
    <img alt="C Sharp" src="https://img.shields.io/badge/-CSharp-3178C6?style=for-the-badge&logo=csharp&logoColor=white">
    <img alt="JWT" src="https://img.shields.io/badge/-JWT-d63aff?style=for-the-badge&logo=jsonwebtokens&logoColor=white">
    <img alt="SQLite" src="https://img.shields.io/badge/-SQLite-003B57?style=for-the-badge&logo=sqlite&logoColor=white">
</p>

## Descrição

Neste desafio você deve desenvolver uma API de autenticação utilizando o .NET Core 6 Minimal APIs.

## 🚀 Tecnologias

- [Core 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [JWT](https://jwt.io/)
- [SQLite](https://www.sqlite.org/index.html)

## 🔰 Instalação

```bash
$ dotnet restore
```

## 🚀 Rodando a API

```bash
$ dotnet run
```

## 🧠 Desafios

### POST `/sign-up`

A rota deve receber um `username`, `password` e `name` dentro do Body da requisição e criar um novo usuário dentro do banco de dados utilizando os dados recebidos.

```json
{
  "username": "fulano123",
  "password": "12345678",
  "name": "Fulano de Tal"
}
```

- [ ] Receber `username`, `password` e `name`.
- [ ] Cria a base do usuário no banco de dados.
- [ ] Criar usuário no banco de dados.
- [ ] `isAdmin` deve ser `false` por padrão.
- [ ] Rota deve retornar o usuário criado na requisição
  - [ ] Não deve conter `isAdmin`
  - [ ] Não deve conter `password`
- [ ] Validar dados recebidos
  - [ ] `username` deve ter no mínimo 5 dígitos
  - [ ] `password` deve ter no mínimo 8 dígitos
  - [ ] `name` deve ter no mínimo 3 dígitos
- [ ] Requisições inválidas devem retornar erro padronizado
  - [ ] Status de resposta deve ser `400`
  - [ ] `username` existente deve retornar status `400`
- [ ] Criptografar senha do usuário antes de salvar no banco de dados

---

**Modelo de Usuário para Banco de dados**

```csharp
public record User
{
    public Guid id { get; init; }
    public string username { get; init; } = default!;
    public string password { get; init; } = default!;
    public string name { get; init; } = default!;
    public Boolean isAdmin { get; init; }
}
```

**Modelo de Requisição Bem Sucedida**

```json
{
  "id": "f1d5e317-cfbb-4111-b38b-819b7c4c9cf8",
  "username": "fulano123",
  "name": "Fulano de Tal"
}
```

**Modelo de Requisição com Erro**

```json
{
  "title": "Bad Request",
  "status": 400,
  "detail": "Usuario já registrado"
}
```

---

### POST `/sign-in`

A rota deve receber um `username` e `password` dentro do Body da requisição e validar os dados, retornando um Token JWT caso estejam válidos.

```json
{
  "username": "fulano123",
  "password": "12345678"
}
```

- [ ] Receber `username`, `password`
- [ ] Validar dados recebidos
  - [ ] `username` deve ter no mínimo 5 dígitos
  - [ ] `password` deve ter no mínimo 8 dígitos
- [ ] Encontrar usuário no Banco de Dados
- [ ] Verificar `password` da requisição com Hash no Banco de Dados
- [ ] Requisições inválidas devem retornar erro padronizado
  - [ ] Status de resposta deve ser `400`
  - [ ] `username` não existente deve retornar status `400`
- [ ] Requisições válidas devem retornar Token JWT para o cliente
  - [ ] Token deve conter informações do usuário

---

**Modelo de Requisição Bem Sucedida**

```json
"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiQW5kcmUgU2FtcGFpbyIsInJvbGUiOiJVc2VyIiwibmFtZWlkIjoiZDRjZDA4MzUtYTFkMy00MTAxLWE2YjEtZTIyZWM0YzUxNDE1IiwibmJmIjoxNjQ3NTI2ODQ4LCJleHAiOjE2NDc1MzQwNDgsImlhdCI6MTY0NzUyNjg0OH0.ar2hJrwY3zG-g7FbupjvgGtLfjLoZo7LQ88epA9VW0k"
```

---

## 📅 Entrega

Esse desafio deve ser entregue a partir da plataforma Edx, enviado em formato de repositório de código, plataforma de edição de código online ou zip. **Lembre-se de manter o arquivo público antes de compartilhar com o instrutor.**

Feito com 💜 por [Andre Sampaio](https://github.com/apsampaio) <img src="https://media.giphy.com/media/hvRJCLFzcasrR4ia7z/giphy.gif" width="25px">
