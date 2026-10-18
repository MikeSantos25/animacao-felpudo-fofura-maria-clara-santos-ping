Felpudo e Fofura - Prática (PJ 2026.2)

Link do Jogo no Play Unity: [Clique aqui para ser direcionado a página](https://play.unity.com/en/games/87ef230c-5a74-4eab-9766-2e5d6738fce6/webgl-builds)

Sobre o Projeto
Movidos por um sentimento inabalável, Felpudo e Fofura caminham um ao encontro do outro. A paixão de Felpudo transborda em um rastro de corações vermelhos, enquanto a paixão de Fofura é cercada por corações em roxo. Mesmo que tudo e todos estejam contra esse amor, eles tiram forças de onde não têm para avançar o mais rápido possível e ficarem juntos, persistindo firmes até o fim com muito amor transbordando.

Funcionalidades Implementadas:

Alterações de Código MoveFelpudo & MoveFofura com ajustes nos valores de velocidade base no inspetor, implementação de uma desaceleração suave quando os personagens se aproximam e corrigindo alguns intervalos para evitar bugs.

Sistema de Partículas com a criação do material material_coracao com shader *Particles/Standard Unlit* (Cutout),configuração o emissor em formato *Box* para espalhar os corações na horizontal, definidas as cores e direções distintas para cada lado (vermelho do lado do Felpudo e roxo do lado da Fofura), aumentado o `Start Lifetime` e `Emission Rate` para preencher a tela de forma harmoniosa e a correção nos Position (Z) em relação a cena. 

Aluna: Maria Clara Santos Ping De Carvalho
