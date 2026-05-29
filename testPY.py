import re
from playwright.sync_api import Page, expect

def test_ejemplo_busqueda(page: Page):
    # 1. Navegar a la página de Google
    page.goto("https://www.google.com")
    
    # 2. Localizar la barra de búsqueda y escribir
    # (Playwright maneja las esperas por detrás)
    barra_busqueda = page.get_by_role("combobox", name="Buscar")
    barra_busqueda.fill("Playwright python")
    barra_busqueda.press("Enter")
    
    # 3. Validar que el título de la página contiene lo que buscamos
    expect(page).to_have_title(re.compile("Playwright python"))