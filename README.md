# Gerenciamento de Itens
Aplicativo desenvolvido para o processo seletivo do Bootcamp IBID, construído em Windows Form e utilizando banco de dados relacional (SQLServer).

## Baixe o repositório
💻 Primeiramente baixe este repositório através do botão code e download zip (deverá ter um descompressor de arquivos) e descomprima no lugar de sua preferência.

# Configurações no Visual Studio
## Executando a Solução
📂 Entre na pasta "WF_ADONet" e execute o arquivo "WF_ADONet.sln" com o Visual Studio, sendo essa a solução, ou seja, a amarração do projeto com todos seus arquivos já abertos.

## Configurando o banco
🖥 Abra o arquivo "Banco.cs", sendo essa a classe de ligação com o banco de dados. Nessa classe, haverá a seguinte linha de código:
```
 private string stringConexao = "Data Source=localhost;Initial Catalog=banco1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
```
Substitua a parte em que diz "banco1" pelo nome do banco que você irá criar: 
```
Initial Catalog=banco1
```
E ficará assim: 
```
Initial Catalog=nomeDoBanco
```

# Configurações no SQLServer
## Executando query (consulta)
🗄 Abra seu gerenciador de banco de dados (como por exemplo o SQLServer Management Studio), entre no arquivo baixado chamado "Query Banco de dados.txt", copie o conteúdo, crie uma nova consulta e cole o conteúdo copiado.

Logo após, execute a **primeira** linha de comando: 
```
CREATE DATABASE nomeDoBanco;
```
Substituindo o "nomeDoBanco" pelo nome que preferir que seja dado a base de dados.

Então execute a **segunda** linha de comando: 
```
USE nomeDoBanco;
```
Agora substuindo o "nomeDoBanco" pelo nome que você utilizou na linha anterior.

Com a base de dados criada e em uso, agora somente basta criarmos nossa tabela executando o comando:  
```
CREATE TABLE itens (
 id INT PRIMARY KEY NOT NULL,
 nome VARCHAR(50) NOT NULL
)
```

# Executando o aplicativo
🖱 Com tudo configurado, tanto Visual Studio, quanto o banco de dados, temos de executar a solução através do próprio Visual Studio no sinal de "**play verde**" e o aplicativo estará em execução. Agora o CRUD é executável e inteligível, logo preencha o campo necessário e adicione/edite/delete de acordo com as necessidades.
