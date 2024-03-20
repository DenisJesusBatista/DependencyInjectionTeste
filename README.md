### DependencyInjectionTeste
# Singleton 
- Serviço de injeção de dependência faz new somente quando for solcitado e fica em memória o valor, ficando inalteravel como exemplo da API.
- Só cria novo new quando para a execução da API.


# Transient
- Serviço de injeção de dependência faz new a todo o momento na classe.

# Scoped
- O scoped faz um new todas as vezes, no escopo da requisição.
- Quando a requisição acaba, mata todo o processo e tira da memória.
