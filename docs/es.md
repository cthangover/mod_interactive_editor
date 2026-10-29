# Editor de interactivos — objetos clicables sobre el fondo de una escena

El editor de interactivos edita los objetos clicables de `interactive_base` — puertas, cofres, lámparas, zonas activas invisibles — encima del fondo al que pertenecen. Colocas y das forma al colisionador de cada objeto con el ratón y rellenas su sprite, capa, cursor y comandos al hacer clic.

## Cómo abrirlo

Botón del martillo en la barra del juego → **Editor de interactivos**.

## Editar objetos

![El editor de interactivos con graveyard_interactives.json de cthangover_game: los objetos crypt_spot y book_wipe, el colisionador rectangular de crypt_spot seleccionado con sus asas y sus propiedades: capa foreground, cursor PointingHand, colisionador, resaltado y la acción de escenario.](assets/interactive-editor.jpg)

1. Elige un mod y un archivo de interactivos (`interactives/*.json`). **Objetos del archivo** lista sus objetos; **+ Nuevo**, **Duplicar** y **Borrar objeto** cambian la lista.
2. La vista previa muestra el fondo de la escena cuyo escenario añade el objeto (el editor lo busca en los escenarios); **Fondo de vista previa** elige otro.
3. Pulsa un colisionador para seleccionarlo y arrastra sus asas. **Forma** es rectángulo, círculo o polígono; en modo polígono un clic en el fondo añade un vértice y el botón derecho sobre un vértice lo borra (al menos tres vértices).
4. **Propiedades**: **ID**, **Textura** (vacía: una zona clicable invisible), **Capa**, **Orden Z**, **Cursor**, **Activado**, **Visible** y **Comandos al hacer clic (uno por línea)**. **Resaltado** (**Color**, **Escala**) define cómo se ilumina y crece el objeto bajo el cursor. En **Acciones**, **Escenario** es un archivo `.scenario` que se juega al hacer clic, y **Al entrar el ratón** / **Al salir el ratón** contienen comandos que se ejecutan cuando el cursor entra o sale.
5. Ctrl+S guarda el archivo. Un ID repetido o vacío se rechaza con un mensaje.

El archivo guardado son datos normales del mod. El juego en marcha lo recoge con la recarga en caliente de mods (automática tras guardar, o Ctrl+Mayús+R), y los objetos aparecen cuando su escenario los añade a una escena.

## Dependencias

`tools_base`, `scenario_tools_base`, `interactive_base`, `ui_base`.
El paquete antiguo `editor_tools` instala este mod junto con las demás ventanas de autor.
