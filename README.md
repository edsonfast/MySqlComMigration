# MySqlComMigration
Projeto Teste Entity Framework Code First com MySql/Maria DB 10.6

Referencias:
https://devmais.wordpress.com/2015/02/26/configurando-mysql-entityframework-code-first-passo-a-passo/

http://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx
http://stackoverflow.com/questions/20108278/clickonce-updates-and-the-entity-framework-code-first
http://www.codeproject.com/Articles/17003/ClickOnce-Quick-steps-to-Deploy-Install-and-Update
https://msdn.microsoft.com/en-us/data/jj591621
http://stackoverflow.com/questions/12130059/how-turn-off-pluralize-table-creation-for-entity-framework-5
http://social.technet.microsoft.com/wiki/pt-br/contents/articles/17952.entity-framework-code-first-migrations-com-mysql.aspx


Bugfix:

https://mysqlconnector.net/troubleshooting/failed-add-reference-comerr/
A fix from Oracle is now available in MySql.Data version 8.0.32.1


"The ADO.NET provider with invariant name 'MySql.Data.MySqlClient' is either not registered in the machine"
https://stackoverflow.com/questions/38452900/the-ado-net-provider-with-invariant-name-mysql-data-mysqlclient-is-either-not
Instalar o Connector/NET 8.0.26 usando o MySql Installer


"NotSupportedException: Versions of MySQL prior to 5.6 are not currently supported"
https://stackoverflow.com/questions/71621658/versions-of-mysql-prior-to-5-6-are-not-currently-supported
Incluir version=9.9.0 no my.ini grupo [mysqld]

