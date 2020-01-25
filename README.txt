Importador de arquivos.

1. Ao executar o app, todos arquivos da pasta são processados em um pool de threads, que dispara uma task para cada arquivo.
2. Após isso é montado um listener que fica monitorando a pasta, e disparando processo caso chegue novos arquivos nela.
3. A contabilização do dados é feita no momento da carga visando desempeho e foco no resultado.
4. Duplicidades no arquivo não foram validadas por que não é (não foi definido) um requisito, mesmo assim é possivel fazer de forma simples sem perda de desempenho, guardando uma chave e fazendo uma busca binaria no momento da contabilização.
5. É possivel ter mais dados de resultados, apenas implementando a contabilização especifica.
6. Tem 2 exemplos de testes unitarios bem simples, um do parser e outro de leitura e cálculo.
7. As pastas de trabalho estao definidas na classe configuration assim como outras configs, as pastas caso não existam serão criadas.
