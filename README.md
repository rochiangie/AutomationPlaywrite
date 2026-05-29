# AutomationPlaywrite

Scripts y ejemplos para ejecutar pruebas con Playwright en JavaScript, Python y C#.
Todos los scripts envían un mensaje al formulario de contacto de `https://www.angierochi.com`.

## JavaScript
1. Desde `O:\PlaywriteTests\AutomationPlaywrite` ejecuta:

```powershell
npm install
npm run test:js
```

## Python
1. Instala Playwright en tu entorno Python:

```powershell
pip install playwright
python -m playwright install
```

2. Ejecuta el script:

```powershell
python testPY.py
```

## C#
1. Restaura el proyecto:

```powershell
dotnet restore
```

2. Ejecuta las pruebas:

```powershell
dotnet test
```

## Qué no subir a Git
- `node_modules/`
- `bin/`
- `obj/`
- `resultado_contacto.png`
- `package-lock.json` (si no deseas versionar el lock file local)

Si no quieres subir tus cambios al repositorio remoto, usa:

```powershell
git restore README.md testCSharp.cs testJS.js testPY.py
git clean -fd node_modules bin obj package-lock.json resultado_contacto.png PlaywrightTests.csproj
```

> Esto devolverá el proyecto al estado limpio del último commit y eliminará los archivos generados localmente.

