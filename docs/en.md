# Interactive Editor — clickable objects on a scene background

The Interactive Editor edits the clickable objects of `interactive_base` — doors, chests, lamps, invisible hot spots — on top of the background they belong to. You place and reshape each object's collider with the mouse and fill in its sprite, layer, cursor and click commands.

## Opening it

Hammer button on the in-game toolbar → **Interactive Editor**.

## Editing objects

![The Interactive Editor with graveyard_interactives.json of cthangover_game: the objects crypt_spot and book_wipe, the rectangle collider of crypt_spot selected with its handles, and its properties: layer foreground, cursor PointingHand, collider, highlight and the scenario action.](assets/interactive-editor.jpg)

1. Pick a mod and an interactives file (`interactives/*.json`). **Objects in file** lists its objects; **+ New**, **Duplicate** and **Delete object** change the list.
2. The preview shows the background of the scene whose scenario adds the object (the editor scans scenarios for it); **Preview background** picks another one.
3. Click a collider to select it and drag its handles. **Shape** is a rectangle, a circle or a polygon; in polygon mode a click on the background adds a vertex and RMB on a vertex deletes it (at least three vertices).
4. **Properties**: **ID**, **Texture** (empty — an invisible clickable area), **Layer**, **Z order**, **Cursor**, **Enabled**, **Visible**, and **Commands on click** (one per line). **Highlight** (**Colour**, **Scale**) sets how the object lights up and grows under the cursor. Under **Actions**, **Scenario** is a `.scenario` file played on click, and **Hover in** / **Hover out** hold commands run when the cursor enters or leaves.
5. Ctrl+S saves the file. A duplicate or empty ID is refused with a message.

The saved file is ordinary mod data. The running game picks it up with the mod hot reload (automatic after saving, or Ctrl+Shift+R), and the objects appear when their scenario adds them to a scene.

## Dependencies

`tools_base`, `scenario_tools_base`, `interactive_base`, `ui_base`.
The older `editor_tools` package installs this mod together with the other authoring windows.
