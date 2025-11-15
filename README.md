# Shaloo World

Um jogo educativo sobre **empatia** e **segurança emocional**.  
Desenvolvido em parceria com a **Associação Brasileira da Síndrome de Williams (ABSW)** como projeto da **Belas Artes**.

---

## Sumário
- [Público-Alvo e Objetivos](#publico-alvo)
- [Mecânicas do jogo](#mecanicas-jogo)
- [Universo e Personagens](#universo-personagens)
- [Personagens](#personagens)
- [Direção de Arte](#direcao-arte)
- [Detalhes Técnicos](#detalhes-tecnicos)
- [Referências Bibliograficas](#bibliografia)


---
### Visão Geral
**Shaloo World** é um jogo educativo no estilo **endless runner**.  
O jogador ajuda um personagem carismático a correr por cenários do cotidiano — como **escola, parque, casa e cidade futurista** — tomando decisões que ensinam **empatia, autocuidado e segurança emocional**.  

O jogo combina **diversão e aprendizado** para estimular comportamentos positivos e promover a consciência social de forma acessível, leve e encantadora.

- **Estilo de jogo**: Aventura educativa runner inclusivo.
- **Foco**: Aprendizado, inclusão, acessibilidade.
- **Experiência proposta**: Diversão, empatia, segurança digital.
- **Tipo de arte**: Cel-Shading 3D.
- **Formato**: Single player.
- **Plataforma**: Dispositivos móveis.
- **Engine**: Unity 6.

---

<a name="publico-alvo"></a>
# Público-Alvo e Objetivos

## Público-Alvo Primario
O jogo foi desenvolvido para crianças de 6 a 12 anos, com foco especial na inclusão de pessoas com Síndrome de Williams. Essas crianças estão inseridas em um ambiente escolar e estão em processo natural de aprendizado sobre como interagir socialmente e compreender comportamentos seguros e empáticos no cotidiano. São emocionalmente sensíveis, podendo se apegar ou se magoar com facilidade, e muitas vezes enfrentam dificuldades para se expressar verbalmente de forma clara. O jogo busca oferecer um espaço acolhedor e educativo, que respeite essas características e estimule o desenvolvimento emocional e social de forma lúdica.

## Público-Alvo Secundario
Além do público primário, o jogo também é voltado para:
- Pessoas com limitações motoras ou deficiência física, com idades entre 6 e 88 anos;
- Pessoas com sensibilidade auditiva ou sensorial;
- Crianças neurotípicas, promovendo a convivência inclusiva e o desenvolvimento da empatia entre diferentes perfis de desenvolvimento;

## Persona Publico-Alvo primario
Ana Clara tem 9 anos, está no ensino fundamental e vive em uma cidade de porte médio, frequentando uma escola inclusiva. Ela tem Síndrome de Williams, é muito sensível emocionalmente, se apega com facilidade às pessoas e pode se magoar rapidamente. Adora música e cores vibrantes, mas enfrenta dificuldades para se expressar verbalmente, preferindo gestos e desenhos como forma de comunicação. Seu maior desejo é se sentir parte do grupo de colegas, aprender de forma divertida e encontrar experiências que transmitam segurança e acolhimento. No jogo, ela busca reforço positivo para se sentir confiante e aprender sobre respeito, amizade e segurança digital enquanto se diverte em missões acessíveis e coloridas.

## Persona Publico-Alvo secundario
Carlos Eduardo tem 35 anos, trabalha em home office e usa os jogos como forma de lazer e relaxamento. Ele tem uma limitação motora nos braços que dificulta movimentos finos e também é sensível a sons muito altos ou repetitivos. Prefere jogos com controles simplificados, como clicar e arrastar, e valoriza experiências inclusivas e educativas que possa compartilhar com seu filho de 7 anos. Seu objetivo é se divertir sem barreiras físicas, sentir que está aprendendo algo útil e participar de uma experiência que promova empatia e valores positivos, sem se sentir excluído por suas limitaçõe

<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/williams.jpeg" alt="project-screenshot" height="200">



## Objetivos
O principal objetivo do jogador em Shaloo World é permanecer o maior tempo possível explorando o mundo do jogo, evitando obstáculos perigosos que podem resultar na perda de pontos ou no encerramento da partida. Além disso, o jogador deve completar missões educativas que promovem valores como respeito, empatia e segurança digital. Ao longo da jornada, é possível acumular medalhas de honra como reconhecimento pelo progresso, superação de desafios e comportamento positivo dentro do universo do jogo.


## Proposta de Inclusão
Shaloo World foi concebido para ser um espaço inclusivo e educativo. O jogo oferece controles simplificados e interface visual acessível, garantindo que crianças com dificuldades motoras ou de aprendizado possam participar plenamente. Além disso, insere de forma lúdica noções de segurança digital e social, ajudando as crianças a reconhecer comportamentos seguros e respeitosos. A proposta de inclusão não se limita ao acesso, mas também promove empatia e convivência entre diferentes perfis de desenvolvimento, reforçando valores como respeito, autocuidado e amizade.

### Moodboard Persona
<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/game-moodboard/public-moodboard.jpeg" alt="project-screenshot" height="200">

---

<a name="mecanicas-jogo"></a>
# Game Design

## Condição de Vitoria e Derrota
Por ser um jogo arcade de corrida infinita, não é possivel zerar o jogo. A condição de vitoria é definita por metas pessoais ou desafios do jogo. Completando todas as missões, e desbloqueando todas as fases, atingindo notas ou pontuações desejadas.

## Condição de Derrota
Falhar nas missões ou coletar itens negativos, fara com que a saude durante um ciclo de partida diminua, acabando quando ficar menor ou igual a zero.

## Mecânicas
### Moodboard Mecânica
<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/game-moodboard/mecanicas.jpeg" alt="project-screenshot" height="200">

### Coleta de Itens
Jogador coleta objetos positivos (ex.: recicláveis, seguros, empáticos) e evita os negativos (ex.: lixo, perigos digitais).

Pontuação baseada em escolhas corretas (+100) ou penalidades por erros (-100).

### Movimentação Simples
Controle por clique e arrastar ou setas laterais.

### Missões Educativas
Cada fase tem uma missão com tema específico (ex.: limpar o planeta, identificar atitudes seguras online).

Ao completar, o jogador ganha medalhas de honra e desbloqueia novos conteúdos.

### Sistema de Progressão
Evolução por pontos acumulados e medalhas.
Fases com dificuldade crescente e novos desafios visuais e cognitivos.

### Controles
- **Pular:** arrastar para cima  
- **Deslizar:** arrastar para baixo  
- **Desviar:** arrastar para os lados
  
<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/controllers.png" alt="project-screenshot" height="200">



### Tutorial
<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/tutorial/tutorial.jpg" alt="project-screenshot" height="200">

# UI (Interface do Usuario)
## Wireframe
<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/wireframe/wireframe.jpg" alt="project-screenshot" height="200">

---

<a name="universo-personagens"></a>
# Universo e Personagens
## Narrativa
Em terras chinesas, onde há uma natureza esplendorosa, vive Pandy, um urso panda carismático com muitos amigos. Pandy ama a terra onde vive desde sempre, tendo uma curiosidade fruto desse amor. No entanto, ele deve se cuidar dos perigos que pode enfrentar. Entre eles está seu melhor amigo, Lucy, um tigre que coexiste de forma harmoniosa com ele.

Essa harmonia equilibra a personalidade cuidadosa de Pandy com o jeito descuidado de Lucy, que vive entrando em problemas.

## Ambientação
O jogo se passa na China, em uma região repleta de montanhas, árvores e plantas características do país. O ambiente transmite uma atmosfera de paz e harmonia, reforçando o tom acolhedor da narrativa. Algumas áreas do jogo também podem apresentar neve, inspiradas nas paisagens do norte da China e em regiões montanhosas, enriquecendo a diversidade visual e climática do cenário.

## Moodboard Ambientação
<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/game-moodboard/nature-ambience.jpeg" alt="project-screenshot" height="200">

## Personagens
- **Pandy (Protagonista):** panda curioso, gentil e cheio de energia.  
- **Mentor:** Pai e Mãe de Pandy  
- **Antagonista:** Lucy, expecialista em criar desafios para seu melhor amigo Pandy. 

## Moodboard Personagens
<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/game-moodboard/characters.png" alt="project-screenshot" height="200">

---

<a name="personagens"></a>
## Personagens
### Pandy
O protagonista é Pandy, um pequeno panda curioso, gentil e cheio de energia. Ele adora
explorar o mundo, conhecer novas pessoas e ajudar quem precisa.
Pandy representa a pureza e o entusiasmo das crianças, mas também enfrenta desafios
que exigem atenção, cuidado e boas escolhas. Ao longo da jornada, ele aprende o
verdadeiro significado de autocuidado, empatia e segurança emocional, mostrando
que coragem também é saber pedir ajuda e agir com o coração.

<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/pandy.png" alt="project-screenshot" height="200">

### Lucy
O vilão da história é um jovem bichinho que vive fazendo bagunça e tomando decisões sem pensar. Ele adora desafiar o jogador, criando situações difíceis que precisam ser resolvidas com cuidado e inteligência. Esse personagem não se preocupa com a natureza nem com sua própria segurança, e por isso acaba entrando em confusão. Mas Pandy, mesmo sendo cuidadoso e calmo, está sempre por perto para ajudá-lo quando as coisas dão errado, mostrando que amizade e gentileza fazem toda a diferença.

<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/tigre_v2.jpg" alt="project-screenshot" height="200">

<a name="direcao-arte"></a>
## Direção de Arte
- **Estilo:** Toon / Cartunesco e Colorido  
- **Tipografia:** Berlin Sans FB (Titulo), Nunito (Corpo).

Shallo world carrega uma motivação de trazer uma experiencia cartunesca para o jogador com um mundo agradavel, colorido e bonito, com fases em diversos biomas e natureza. Um paraiso para que o jogador se sinta bem jogando, mostrar os perigos mas ainda mais a beleza que há no mundo e a importancia de cuidarmos dele.

---
<a name="detalhes-tecnicos"></a>
## Detalhes Técnicos
- **Engine:** Unity (3D)  
- **Plataforma de Lançamento:** WebGL (via navegador) – hospedado no GitHub Pages
- **Classificação Indicativa:** Livre  

---
## Plataforma de publicação
O jogo será publicado na Web. Enquanto não possui domínio próprio, será disponibilizado em uma plataforma provisória, simulando uma situação real de produção. Dessa forma, poderá ser jogado em todos os dispositivos.
<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/softwares/github.png" alt="project-screenshot" height="200">

---
## Sofwares
<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/softwares/softwares.jpeg" alt="project-screenshot" height="200">

## Versões futuras
Para oferecer uma melhor experiência ao usuário, os autores do jogo planejam implementar um banco de dados, possibilitando funcionalidades online como salvar o progresso na nuvem, adicionar amigos, acessar rankings e outras opções que ampliem a interação e o engajamento dos jogadores.

## Equipe
**Orientador:** Prof. Dr. Leandro Wendel Martins  

**Desenvolvedores:**  
- Alexander Cabral Santiago Lucena  
- Ana Luiza de Lara Moreira  
- Lucas Santos Breda  
- Vinicius Lopes de Azevedo  

---


<a name="bibliografia"></a>


<img src="https://viniloppes.github.io/web-unity-build-shaloo-world/assets/image1.png" alt="project-screenshot" height="200">

