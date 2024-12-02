# Notes

## Paradigmas der webdevelopment

**Single Page Application (SPA)**
- heel veel client-side code (JS/WebAssembly (WASM))
- herlaadt de pagina niet - URL-wisselen is nog steeds mogelijk
- gebruiksvriendeiljkheid hoog in het vaandel
- nadelen: initiele laadtijd duurt lang
  - lazy loading
- beefier client nodig - JSON.parse()  5MB
- hip
- niet altijd nodig - complexiteit
- niet optimaal voor Search Engine Optimization (SEO)
- libs: React Vue Angular Svelte Qwik AngularJS Solid Ember Inferno Blazor

**Server-side rendering (SSR)**
- altijd complementair aan de SPA
- stuurt hele HTML voor de initiele pagina
- op de achtergrond wordt dan alle interactieve code opgestuurd
  - JS/WASM
  - hydration  partial hydration progressive hydration streaming hydration
- libs: Next.js Nuxt.js @angular/ssr SvelteKit QwikCity SolidStart ... ... ASP.NET Core

**Static site generation (SSG)**
- documentatiewebsites
- poept heel veel HTML-bestandjes uit
- adhv een catalogus/grote database voor elk product => .html  product-keyboard-38384.html
  - tijdens het builden

  index.php?page=products&productId=4358
- libs: docusaurus docgen javadoc HUGO 11ty Next.js @angular/ssr

**Multi Page Application (MPA)**
- wat jullie tot nu toe hebben gedaan met Blazor
- je merkt dat hij laadt als je wisselt van pagina
- de hele nieuwe pagina ophalen
- alle oude HTML gaat weg
- alle nieuwe HTML wordt gerenderd
- Flash Of Unstyled Content
- niet hip

## Interactieve deel van Blazor

**Blazor Server**
- stuurt niet de hele .NET-runtime over
- code draait op de server
- iedere UI-interactie wordt gecommuniceerd naar de server
  - server bepaalt de nieuwe UI-state
  - WebSockets
  - slechte verbinding niet ideaal - parkeergarage/achterhoek

**Blazor WebAssembly (WASM)**
- code draait in de browser
- gooit de micro-versie van de hele .NET runtime naar de client (browser)
  - "hello world" 7MB - 10 - 12MB
- C# => WebAssembly   assembly

## Selling points Blazor

- C#
- Microsoft
- relatief makkelijk om van MPA => SPA
- content projection
  ```razor
  <JouwComponent Param="12">
      <Button>Hoi @bla</button>
  </JouwComponent>
  
  ^-- RenderFragment
  ```

- nadelen:
  - community
  - grote bundle
  - HMR  .NET 6   dotnet watch run
  - debuggen?
  - compartmentalisatie lastiger
  - unittesten
    - ElementReference EditContext EditForm










