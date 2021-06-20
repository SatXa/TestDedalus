# TestDedalus
Prueba técnica para Dedalus



Sin terminar. El problema es la unión del frontend al backend: no sé cómo hacer para recoger una cadena en el front, pasarlo como filtro al back, y devolver los resultados de vuelta a la vista.

En [CapitalCities](TestDedalus/Pages/CapitalCities/CapitalCitySearch.cshtml.cs) línea 27, puedo filtrar pasando el valor de la cadena de filtro por defecto (el valor llega como null y no sé como traerlo desde la vista). Me devuelve las capitales de los países cuyo código ISO o nombre contiene el filtro. He ignorado el resto de problemas por ahora (salen capitales como "None" para Antártida o "-" para algunos territorios que son técnicamente parte de países y no países en sí mismos) ya que son simplemente errores en los datos que se han usado y no errores del programa.

--------------------

## Cuestionario

1. Tu opinión sobre la llamada Clean Architecture.
2. Tu opinión sobre el TDD.
3. Tu opinión sobre el diseño basado en encapsular la lógica de negocio en un dominio.
4. Tu opinión general sobre las metodologías Agile.
5. ¿Has utilizado GIT? ¿Qué opinión tienes sobre esa herramienta?



1.-3.- No sabía lo que eran ni Clean Architecture, ni TDD, ni DDD.
Tras haber investigado un poco, no entiendo demasiado de ninguno de los 3 pero tengo una mínima idea.
Todo lo que ayude a mantener un orden en el trabajo es bueno. Creo que es más importante tener *un orden* que *el mejor orden*.
Me ha llamado la atención el DDD porque ese sí lo entiendo un poco mejor: para proyectos de tamaño considerable y/o que se van a 
mantener en una espacio largo de tiempo, entiendo que es mejor usar DDD aunque suponga un mayor coste al comienzo, si con ello 
los costes de mantenimiento son menores en el futuro. Sin embargo, tiene la desventaja de que también supone un mayor reto para 
los nuevos integrantes de un equipo, los cuales tienen que aprender todo el sistema cuando ya está montado, y no mientras se monta, 
no sé si me explico. Voy a suponer que es un concepto que aplicáis en DXC/Dedalus debido a que tratáis en el ámbito hospitalario 
y en ese caso me parece lógico y razonable, si bien a la vez un poco intimidante, siendo el que está en el lado del aprendizaje, posiblemente.

4.- Mi experiencia (poca, además) se limita a Kanban, pero el tiempo que estuve trabajando con ello me gustó. Tengo interés por 
volver a trabajar con metodologías Agile en el futuro, porque estoy seguro de que son una estricta mejora sobre no tener orden alguno.

5.- Sí, utilizo Git tanto en el trabajo como ocasionalmente en mis proyectos personales. Me parece una herramienta maravillosa y 
me extraña que no esté más extendida incluso entre personas que no pertenezcan al mundo del desarrollo de software, aunque sea 
simplemente por el sistema de control de versiones. Sé que mi opinión es más sobre los sistemas de control de versiones en general 
que sobre Git específicamente, sin embargo.
