from playwright.sync_api import sync_playwright

def test_contacto_angierochi():
    with sync_playwright() as playwright:
        browser = playwright.chromium.launch(headless=False)
        page = browser.new_page()

        page.goto("https://www.angierochi.com", timeout=60000)
        page.wait_for_selector('#contactForm', timeout=60000)

        page.fill('#name', 'Angie Test')
        page.fill('#email', 'angie.test@example.com')
        page.select_option('#service', label='QA Testing / Automatización')
        page.fill('#message', 'Hola Angie, este es un mensaje de prueba desde Playwright.')

        page.click("button[type='submit']")
        page.wait_for_timeout(3000)
        page.screenshot(path='resultado_contacto.png')
        browser.close()

if __name__ == "__main__":
    test_contacto_angierochi()
