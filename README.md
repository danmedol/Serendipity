# Serendipity

> **Language note:** The application output is in Brazilian Portuguese, as it is my native language and this is a personal learning project.

A console application that queries NASA's Near Earth Object Web Service (NeoWs) API to list celestial objects that passed close to Earth on a given date.

---

## About

Serendipity was built as a learning project during my transition from customer service to backend .NET development. It covers HTTP requests, JSON deserialization, async/await, and data modeling in C#.

---

## Features

- Search near-Earth objects by date
- Display each object's name, ID, estimated diameter, relative velocity, miss distance, and collision risk
- Input validation for empty fields

---

## How to Run

**Prerequisites:** [.NET SDK 8.0+](https://dotnet.microsoft.com/download)

**Set your NASA API key as an environment variable:**

Get a free key at [api.nasa.gov](https://api.nasa.gov)

```bash
export NASA_API_KEY="your_api_key_here"
```

**Clone and run:**

```bash
git clone https://github.com/danmedol/Serendipity.git
cd Serendipity
dotnet run
```

---

## Example Output

```
Serendipity 1.1
Enter a date (YYYY-MM-DD): 2026-09-30

5 objects were found near Earth on this date.

Name: (2002 PN6)
ID: 3132507
Estimated diameter: 0.39 KM
Velocity: 5659.92 KM/H
Miss distance: 62349988.91 KM
Collision risk: No
----------------------------------------
```

---

## Tech Stack

- C# / .NET
- System.Text.Json (JSON deserialization)
- System.Net.Http (HTTP requests)
- NASA NeoWs API

---

## What I Learned

- Consuming a REST API with HttpClient and async/await
- Deserializing complex nested JSON into C# classes
- Handling culture-specific number formatting with CultureInfo.InvariantCulture
- Protecting API keys with environment variables
- Git version control

---

## Author

**Daniel** — transitioning from customer service to backend .NET development.

[GitHub](https://github.com/danmedol)

---

---

# Serendipity (Português)

> **Nota sobre o idioma:** O output da aplicação está em português brasileiro, pois é meu idioma nativo e este é um projeto pessoal de aprendizado.

Aplicação de console que consulta a API NeoWs da NASA para listar objetos celestes que passaram próximos à Terra em uma data pesquisada pelo usuário.

---

## Sobre

Serendipity foi desenvolvido como projeto de aprendizado durante minha transição do atendimento ao cliente para o desenvolvimento backend .NET. O projeto cobre requisições HTTP, deserialização de JSON, async/await e modelagem de dados em C#.

---

## Funcionalidades

- Pesquisar objetos próximos à Terra por data
- Exibir nome, identificação, diâmetro estimado, velocidade relativa, distância e risco de colisão de cada objeto
- Validação de input para campos vazios

---

## Como Executar

**Pré-requisitos:** [.NET SDK 8.0+](https://dotnet.microsoft.com/download)

**Defina sua chave da API NASA como variável de ambiente:**

Obtenha uma chave gratuita em [api.nasa.gov](https://api.nasa.gov)

```bash
export NASA_API_KEY="sua_chave_aqui"
```

**Clone e execute:**

```bash
git clone https://github.com/danmedol/Serendipity.git
cd Serendipity
dotnet run
```

---

## Exemplo de Output

```
Serendipity 1.1
Para consultar informações sobre asteroides próximos à terra, digite uma data (no formato AAAA-MM-DD):
2026-09-30

5 objetos foram encontrados próximos à Terra nessa data.

Nome: (2002 PN6)
Identificação: 3132507
Diâmetro: 0,39 KM
Velocidade: 5659,92 KM/H
Distância: 62349988,91 KM
Risco de colisão: Não
----------------------------------------
```

---

## Tecnologias

- C# / .NET
- System.Text.Json (deserialização de JSON)
- System.Net.Http (requisições HTTP)
- NASA NeoWs API

---

## O que Aprendi

- Consumir uma API REST com HttpClient e async/await
- Deserializar JSON aninhado e complexo em classes C#
- Tratar formatação de números com CultureInfo.InvariantCulture
- Proteger chaves de API com variáveis de ambiente
- Controle de versão com Git

---

## Autor

**Daniel** — em transição do atendimento ao cliente para o desenvolvimento backend .NET.

[GitHub](https://github.com/danmedol)
