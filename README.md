# ControleClinicaPsicologia
Documentação do Projeto: Controle de Clínica de Psicologia (Viva Mente)
Visão Geral do Projeto
O projeto é um sistema de controle para uma clínica de psicologia, desenvolvido com ASP.NET Core MVC. O objetivo é gerenciar o cadastro de pacientes, psicólogos e agendamentos de consultas.
TECNOLOGIAS UTILIZADAS
Banco de Dados
•	SQL Server 19: Sistema gerenciador de banco de dados. Com a criação de tabelas: Consultas, Pacientes, Psicólogos.
Linguagens de Programação e Frameworks
•	C#: Linguagem principal utilizada para desenvolvimento back-end.
•	ASP.NET Core MVC: Framework para construção da aplicação web, utilizando o padrão MVC.
•	Entity Framework Core: ORM para interação com o banco de dados.
•	JavaScript: Utilizado para interatividade no front-end.
•	jQuery: Biblioteca JavaScript para manipulação do DOM e chamadas AJAX.
•	Bootstrap: Framework CSS para construção de interfaces responsivas e modernas.
•	HTML/CSS: Linguagens para estruturação e estilização da interface do usuário.
Segurança
•	Token JWT (JSON Web Token): Componente de segurança de uma aplicação, ajudando a garantir que apenas usuários autorizados possam acessar recursos protegidos.
Funcionalidades
•	Cadastro de Pacientes: Permite o registro de novos pacientes, com informações pessoais e de contato.
•	Cadastro de Psicólogos: Psicólogos podem ser cadastrados com suas especialidades e números de registro.
•	Agendamento de Consultas e Listagem de Consultas: Visualização de todas as consultas agendadas, com detalhes de pacientes e psicólogos.
•	Edição e Exclusão de Consultas: Permite modificar ou remover consultas existentes.
Implementação de APIs REST
Permitem o gerenciamento dos dados de pacientes, psicólogos e consultas, possibilitando a criação, leitura, atualização e exclusão (CRUD) através de requisições HTTP.GET /api/pacientes: Retorna todos os pacientes. Exemplo:
•	GET /api/consultas: Retorna uma lista de todas as consultas.
•	POST /api/pacientes: Adiciona um novo paciente.
•	DELETE/api/psicólogos: Deleta o cadastro de um psicólogo
 
