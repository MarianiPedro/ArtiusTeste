Este pacote contém uma solução simples com:
- **Backend**: .NET 8 Web API, EF Core InMemory, Swagger, CORS, princípios **SOLID** (SRP/DIP).
- **Frontend**: React (Vite), formulário para criar produto e tabela para listar.

## Endpoints
- `POST /produto` — body JSON: `{ "nome": "Teclado", "prece": 120.5, "categoria": "Periféricos" }`
- `GET /produto`

## Organização do código
```
Backend/
  Api/Controllers/ProdutoController.cs
  Application/
  Domain/
  Infra/
  ArtiusTeste.csproj
  Program.cs

Frontend/
  src/
  index.html
  package.json
  vite.config.js
```
