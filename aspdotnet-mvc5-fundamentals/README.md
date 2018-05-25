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
  - `[AllowAnonymous]` ist das Gegenattribut. Beispiel: In einem Controller, der für alle Aufrufe eine Authorization erwartet, wird eine Ausnahme definiert:

```C# 
    [Authorize]
    public class SecretController : Controller
    {

        public ContentResult Secret()
        {
            return Content("This is a secret for authenticated users...");
        }

        [AllowAnonymous]
        public ContentResult Overt()
        {
            return Content("Not a secret...");
        }
    }
```
  - `[Authorize(Roles="admin")]` Der Benutzer muss in der Gruppe "admin" sein, um Zugriff zu haben.
  - `[Authorize(Roles="admin,sales")]` Der Benutzer muss in der Gruppe "admin" oder in der Gruppe "sales" sein, um Zugriff zu haben.
  - `[Authorize(Users="bob")]` Der Benutzer 'bob' hat Zugriff.
  - `User.Identity` gibt Zugriff auf die Identität des Benutzers
  - `User.IsInRole` fragt ab, ob der Benutzer Teil einer bestimmten Rolle ist.
  
