# PlantTrees
## Projeto em C#, utilizando ASP NET (MVC), Entity Framework, conceito de API's com SQL Server.

:deciduous_tree: O projeto tem como objetivo incentivar as pessoas a plantarem mais árvores. Com as queimadas e grandes desmatamentos, devemos nos preocupar mais.

:gear: O sistema possuí um banco de dados (SQL Server) integrado com duas tabelas, a "Planters" que seria você, e a "Trees" que são as árvores que você vai plantar. A parte da lógica foi desenvolvida em C#, e o Entity Framework Core foi utilizado para ligar o projeto em um banco de dados. Para o front-end foi usado HTML e CSS, e ASP NET Core.

## :computer: O projeto na prática:

:pushpin:Esse é o formulário para você criar um "plantador"

![20241016_193921(139)](https://github.com/user-attachments/assets/060e1794-4b5c-4f0b-a724-a8f7111c85c2)

:pushpin:E aqui você pode conferir seu cadastro, e o de todos os plantadores.

![20241016_194032(168)](https://github.com/user-attachments/assets/f058f447-1230-4006-9e07-19bd1b6c96b3)

:pushpin:Nesta seção, é onde voocê consegue cadastrar uma árvore que você plantou

![20241016_194116(926)](https://github.com/user-attachments/assets/0abfdefa-9c05-44ec-9a62-e91804377b68)

:pushpin:Note que o contador de árvores aumenta conforme você planta

![20241016_194140(381)](https://github.com/user-attachments/assets/a187d52f-7fc2-46a9-9a48-9a78944ac904)


:writing_hand: O projeto está em constante evolução, será implementado as seguintes funcionalidades:  
- Lista de plantadores ordenada por número árvore plantada, nacionalidade, idade
- Página para mostrar as árvores plantadas (com filtro -> por plantador, por nome de árvore...)
- Exclusão e alteração de dados
