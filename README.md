# MyMinioUploadAPI

Este projeto fornece uma API para fazer o upload de arquivos para um servidor MinIO, utilizando o SDK oficial do MinIO em C#. Ele permite que os arquivos sejam enviados para buckets específicos e oferece a possibilidade de verificar a existência do bucket antes do envio.

## Tecnologias Utilizadas

- **.NET 8.0**: Framework para desenvolvimento da API.
- **MinIO SDK**: Para interação com o servidor MinIO.
- **Swagger/OpenAPI**: Para documentação da API.
- **Microsoft.Extensions.Options**: Para configuração e injeção de dependências.

## Instalação

### Requisitos

- **.NET 8.0 SDK**: Certifique-se de ter o .NET SDK instalado em sua máquina. [Baixe aqui](https://dotnet.microsoft.com/download).
- **MinIO**: Instale o MinIO localmente ou use um servidor MinIO existente.

### Clonando o repositório

```bash
cd MyMinioUploadAPI

dotnet restore

dotnet run

```
