# Projeto AgendaTelefonica
# Criado por Demiraldo Alaim Alves dos Santos desde Julho/2017

**Objetivo do projeto:** suprir necessidade de uma Agenda Telefônica onde as telefonistas possam cadastrar nomes e telefones para posteriores consultas.

**Por que foi necessário:** havia uma Agenda Telefonica criada por outra pessoa usando VB6 e banco de dados PostGre na rede da empresa. A empresa modernizou todos os servidores. O banco de dados da Agenda ficava em um servidor que não iria existir mais. Foi feito então a recuperação dos dados e decidido que não seria mais disponibilizado nenhum servidor e banco de dados só pra guardar poucos dados. Para resolver esse problema, foi proposto por mim a recuperação em arquivos XML que poderiam ficar armazenados em uma pasta em qualquer servidor mais moderno, sem necessidade de banco de dados e alguém para cuidar do banco.
- Você verá que as tabelas agora são arquivos XML e toda a referência entre os arquivos é realizada dentro da aplicação(na verdade, são muito pouco referências).
- Para que fique fácil na hora de fazer um fork deste projeto, foi colocado dentro dele uma pasta chamada \ArquivosXMLBancoDados. Nela você acessa os dados da Agenda através de um CRUD totalmente feito dentro da aplicação.

- Se quiser reiniciar a codificação de Usuários, é só alterar o XML **\CodigosUsuarios.xml**, na tag **Proximo** para 2 (já existe o usuário 1 Admin - senha 1234)
- A codificação do caminho onde ficam os arquivos XML pode ser alterada. Se quiser deixá-los em outra pasta ou na rede. Altere o arquivo App.config, no seguinte trecho:
~~~
    <connectionStrings>
      <add name="CaminhoAgenda" connectionString="\AgendaTelefonicaC#\Agenda\ArquivosXMLBancoDados\"/>
    </connectionStrings>
~~~
- Esse recurso é baseado na biblioteca SystemConfiguration _(consulte documentação da Microsoft posteriormente para maiores informações)_
