const { chromium } = require('playwright');

(async () => {
  // 1. Abre el navegador
  const browser = await chromium.launch();
  const page = await browser.newPage();
  
  // 2. Va a la página de Google
  await page.goto('https://google.com');
  
  // 3. Escribe en la barra de búsqueda y presiona Enter
  await page.fill('textarea[name="q"]', 'Playwright automation');
  await page.press('textarea[name="q"]', 'Enter');
  
  // 4. Toma una captura de pantalla del resultado
  await page.screenshot({ path: 'resultado.png' });
  
  // 5. Cierra el navegador
  await browser.close();
})();