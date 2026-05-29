const { chromium } = require('playwright');

(async () => {
  // 1. Abre el navegador
  const browser = await chromium.launch({ headless: false });
  const page = await browser.newPage();

  // 2. Va a la página de AngieRochi y espera el formulario
  await page.goto('https://www.angierochi.com', { timeout: 60000 });
  await page.waitForSelector('#contactForm', { timeout: 60000 });

  // 3. Completa el formulario de contacto
  await page.fill('#name', 'Angie Test');
  await page.fill('#email', 'angie.test@example.com');
  await page.selectOption('#service', { label: 'QA Testing / Automatización' });
  await page.fill('#message', 'Hola Angie, este es un mensaje de prueba desde Playwright.');

  // 4. Envía el formulario y espera un poco
  await page.click("button[type='submit']");
  await page.waitForTimeout(3000);
  await browser.close();
})();