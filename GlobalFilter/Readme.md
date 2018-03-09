### Global Filters
Ol� galera, voc�s conhecem este recurso Global Query Filters ?, Ele nos permite especificar um filtro em n�vel do modelo e � aplicado automaticamente a todas as consultas que s�o executadas no contexto..

### Uso comum 
* Filtro padr�o em linhas deletadas, inativas 
* Multi-tenancy - Aplicar filtro de multi-tenancy

#### Exemplo
Fa�a um clone no projeto, fa�a um Update-Database via PM, estou utilizando o LocalDB SQL 13.

### Via PM

```
 Update-Database

```


Output

![alt text](img1.png "")



### Limita��o
* N�o pode conter refer�ncias a propriedades de navega��o
* Ele pode ser definido apenas na Entidade 
* O m�todo IgnoreQueryFilters ignora todos os filtros (Global Filters) na entidade, ou seja, n�o podemos remover o filtro em especifico usando este m�todo


### Summary
  Global Query Filter ou Model-Level Query Filter � um recurso incluido no Entity Framework, e pode ajudar a muitos programadores a n�o esque�er de aplicar filtros
