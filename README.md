# IO.Swagger - the C# library for the Saque e Pague Sonda

Modelo de API para o serviço de sonda da Saque e Pague. Parceiro pode requisitar o último estado de uma transação (cancelada, confirmada ou pendente) através das chamadas desta API. Caso não encontre a transação, o serviço retorna o estado pendente.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.1.1-sw2
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen
    For more information, please visit [http://www.saqueepague.com.br](http://www.saqueepague.com.br)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AuthControllerApi();
            var grantType = grantType_example;  // string | Constante passada para este tipo de autenticação: password.
            var password = password_example;  // string | Senha disponibilizada pela SEP.
            var username = username_example;  // string | Usuário disponibilizado pela SEP.

            try
            {
                // Retorna o token de autenticação do serviço.
                AuthResp result = apiInstance.SaqueepagueOauthTokenPost(grantType, password, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthControllerApi.SaqueepagueOauthTokenPost: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthControllerApi* | [**SaqueepagueOauthTokenPost**](docs/AuthControllerApi.md#saqueepagueoauthtokenpost) | **POST** /saqueepague/oauth/token | Retorna o token de autenticação do serviço.
*HealthCheckControllerApi* | [**ActuatorHealthGet**](docs/HealthCheckControllerApi.md#actuatorhealthget) | **GET** /actuator/health | Retorna o estado do serviço.
*SondaApiControllerApi* | [**SaqueepagueSondaPost**](docs/SondaApiControllerApi.md#saqueepaguesondapost) | **POST** /saqueepague/sonda | Retorna o estado de uma transação.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AuthResp](docs/AuthResp.md)
 - [Model.SondaReq](docs/SondaReq.md)
 - [Model.SondaReqTerminal](docs/SondaReqTerminal.md)
 - [Model.SondaReqTransacao](docs/SondaReqTransacao.md)
 - [Model.SondaResp](docs/SondaResp.md)
 - [Model.SondaRespTransacao](docs/SondaRespTransacao.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="BasicAuth"></a>
### BasicAuth

- **Type**: HTTP basic authentication

<a name="OAuth2"></a>
### OAuth2

- **Type**: OAuth
- **Flow**: accessCode
- **Authorization URL**: https://127.0.0.1:3939/saqueepague/oauth
- **Scopes**: 
  - read: Requisições podem somente ver os dados.

