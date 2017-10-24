# LuizaLabsDesafioEmployee

O sistema garate a insserção, listagem com paginação e exclusão de funcionários utilizando .net framework com ASP.NET Web API.

Como pedido no desafio as chamadas seguem o padrão abaixo:

Create: curl -H "Content-Type: application/json" -X POST -d '{"name":"myname","email":"email@email.com", "department":"dpto"}' http://localhost:8000/employee

Delete: curl -H -X DELETE "Content-Type: application/javascript" "http://localhost:8000/employee/1/"

GetPagedList: curl -H "Content-Type: application/javascript" "http://localhost:8000/employee/?page_size=10&&page=1"

Caso não sejam passados parâmetros para a chamada GET, por padrão assumirá page_size = 10 / page = 1


# Run

Para rodar a aplicação:

Executar pelo visual stodio, abrindo o projeto  e pressionando f5.
Também pode-se abrir pela linha de comando:
navegar para a pasta do IIS Express instalado.
executar o comando iisexpress /path:"<caminho da pasta da aplicação webapi>" /port:8000

# Important

Nesta aplicação foi usado o pacote do repositorio nuget EntityFramework, assim pode ser necessário restaurar esses pacotes antes da execussão.

Ainda é preciso configurar uma connection string no arquivo web.config. 
A conection string utilizada:

<<connectionStrings>
      <add name="EmployeeLocal"
      connectionString="Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=DesafioLuizaLabs; Integrated Security=True;"
      providerName="System.Data.SqlClient"/>
</connectionStrings>

OBS: Pode ser necessário alterar essa conection string de acordo com quem for fazer os testes.

