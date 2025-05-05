DVRV_PRIA
Tarea UD4
Tarea UD4
¿Qué contenidos o resultados de aprendizaje trabajaremos?.............................................. 0
Contenidos................................................................................................................................0
Descripción de la tarea........................................................................................................0
One Pager................................................................................................................................. 0
Boceto de la arena....................................................................................................................1
¿Qué te pedimos que hagas?.................................................................................................. 1
Indicaciones de entrega...................................................................................................... 2
Evaluación de la tarea......................................................................................................... 2
Criterios de evaluación............................................................................................................ 2
¿Cómo valoramos y puntuamos tu tarea?..............................................................................2
¿Qué contenidos o resultados de aprendizaje
trabajaremos?
RA1. Desarrolla videojuegos multijugador identificando y relacionando los fundamentos de
programación en red cliente-servidor.
Contenidos
UD4. Conectando
- La Escena
- El Network Manager
- Sincronizando la posición
- Inicialización del User Interface(UI)
- UI Manager
- Script ClientNetworkTransform
Descripción de la tarea
Se pide la implementación de un juego sencillo en Unity definido por este one-pager.
One Pager
Un juego 2D de 2 jugadores (champiñones) que tienen que evitar que la pelota
caiga al agua. Si la pelota (huevo) cae en el agua, el punto se le dará al
jugador que no haya tocado la pelota. Digamos que el jugador azul ha tocado la
pelota, entonces, se volverá un poco más transparente solo para que sepamos que
es el turno del jugador rojo. Y si la pelota, es decir, el huevo, cae en el
0
DVRV_PRIA
Tarea UD4
agua, se le da un punto al jugador azul porque el jugador rojo no la tocó.
Aunque siéntete libre para modificarlo como consideres mientras siga utilizando
multijugador en red.
Boceto
Aunque siéntete libre para modificarlo como consideres mientras siga siendo funcional
¿Qué te pedimos que hagas?
El desarrollo solo es necesario que llegue hasta que para que el cliente pueda moverse
instantáneamente (Client authoritative), y luego envíe los datos al servidor para actualizarlos
para el Host. El Host y el cliente se deben de poder conectar entre sí y cada uno mover su
jugador. El manejo del Huevo se deja para posteriores prácticas.
En caso de haber modificado el one-pager, debes ajustarlo a tu proyecto.
Indicaciones de entrega
- La URL del proyecto de GitHub donde reside el proyecto, con una invitación a la cuenta del
profesor mdc-ara en el caso de que sea privado. Debe de estar presente claramente en la
primera página del pdf.
- Un PDF con capturas de pantalla del proceso de creación, debidamente explicadas, como
de secciones relevantes del código, también debidamente explicadas.
- La página del proyecto de GitHub debe mostrar una release con el ejecutable final.
1
DVRV_PRIA
Tarea UD4
Una vez realizada la tarea, el envío se realizará a través de la plataforma. El archivo se
nombrará siguiendo las siguientes pautas:
Apellido1_Apellido2_Nombre_PRIA04_Tarea.pdf
Asegúrate que el nombre no contenga la letra ñ, tildes ni caracteres especiales extraños. Así
por ejemplo la alumna Begoña Sánchez Mañas para la primera unidad didáctica de PRIA,
debería nombrar esta tarea como...
sanchez_manas_begona_PRIA04_Tarea.pdf
Evaluación de la tarea
Criterios de evaluación
RA1.a) Se ha controlado el estado de red del juego utilizando un administrador de red.
RA1.b) Se han configurado juegos multijugador alojados en el cliente.
RA1.c) Se ha utilizado un serializador de datos con propósito general.
RA1.d) Se han remitido y recibido mensajes de red.
RA1.e) Se han enviado comandos de red de clientes a servidores.
RA1.h) Se ha diseñado el modelo cliente y sus características.
¿Cómo valoramos y puntuamos tu tarea?
Rúbrica de evaluación. Para que la tarea se considera apta se debe de completar:
- Implementación adecuada de Network Objects, Network Transform
- Conexión funcional entre Host y Cliente
- Implementación básica del movimiento Client-Authoritative
- Utilización de herramientas de control de versiones -como GitHub-
- Release con el ejecutable final
