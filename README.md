# Projeto AgendaTelefonica
**Objetivo do projeto:** suprir necessidade de uma Agenda Telefônica onde as telefonistas possam cadastrar nomes e telefones para posteriores consultas.

**A empresa possuía uma Agenda Telefônica desenvolvida por outra pessoa, utilizando VB6 e um banco de dados PostgreSQL hospedado na rede interna. Com a modernização dos servidores, o banco de dados utilizado por essa aplicação estava em um servidor que seria desativado e não teria continuidade.

Diante disso, foi realizada a recuperação dos dados da Agenda e decidiu-se que não seria viável manter um servidor e um banco de dados dedicados apenas para armazenar um volume pequeno de informações. Para resolver essa situação, propus uma alternativa mais simples e eficiente: migrar os dados para arquivos XML, que podem ser armazenados em qualquer pasta de um servidor moderno, eliminando a necessidade de um banco de dados e de manutenção específica.

Agora, as antigas tabelas foram convertidas em arquivos XML, e todas as referências entre esses arquivos são gerenciadas diretamente pela aplicação (embora haja pouquíssimas referências cruzadas).

Para facilitar o uso e a replicação do projeto (por exemplo, em forks), foi incluída uma pasta chamada \ArquivosXMLBancoDados dentro do próprio projeto. Nela, é possível acessar os dados da Agenda por meio de um CRUD totalmente implementado na aplicação.

- Se quiser reiniciar a codificação de Usuários, é só alterar o XML **\CodigosUsuarios.xml**, na tag **Proximo** para 2 (já existe o usuário 1 Admin - senha 1234)
- A codificação do caminho onde ficam os arquivos XML pode ser alterada. Se quiser deixá-los em outra pasta ou na rede. Altere o arquivo App.config, no seguinte trecho:
~~~
    <connectionStrings>
      <add name="CaminhoAgenda" connectionString="\AgendaTelefonicaC#\Agenda\ArquivosXMLBancoDados\"/>
    </connectionStrings>

