Importador de arquivos.

1. Ao executar o app, todos arquivos da pasta s�o processados em um pool de threads, que dispara uma task para cada arquivo.
2. Ap�s isso � montado um listener que fica monitorando a pasta, e disparando processo caso chegue novos arquivos nela.
3. A contabiliza��o do dados � feita no momento da carga visando desempeho e foco no resultado.
4. Duplicidades no arquivo n�o foram validadas por que n�o � (n�o foi definido) um requisito, mesmo assim � possivel fazer de forma simples sem perda de desempenho, guardando uma chave e fazendo uma busca binaria no momento da contabiliza��o.
5. � possivel ter mais dados de resultados, apenas implementando a contabiliza��o especifica.
6. Tem 2 exemplos de testes unitarios bem simples, um do parser e outro de leitura e c�lculo.
7. As pastas de trabalho tao definidas na classe configuration assim como outros dados, as pastas caso nao existam ser�o criadas.