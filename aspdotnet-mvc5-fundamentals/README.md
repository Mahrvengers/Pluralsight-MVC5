# ASP.Net Fundamentals


## Identity and Security

  - Wenn man eine Anwendung erstellt, hat man die Möglichkeit auszuwählen, welche Form der Authentication man nutzen möchte.

### Individual User Accounts / Einzelbenutzer-Accounts

  - Register + Login
  - (Siehe Projekt)
  - Alle Controller-Funktionen, die mit dem Authorize-Attribut annotiert sind, sind nur für angemeldete Benutzer zugelassen:

```C#
    public class SecretController : Controller
    {
        [Authorize]
        public ContentResult Secret()
        {
            return Content("This is a secret for authenticated users...");
        }

        // GET: Secret
        public ContentResult Overt()
        {
            return Content("Not a secret...");
        }
    }
```
  - `[Authorize]` kann auch an Controllern hinterlegt werden.
  
