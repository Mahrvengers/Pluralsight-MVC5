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
  
Wir stellen überrascht fest, dass man in der Anwendung angemeldet sein kann, auch wenn die Anwendung einen gar nicht kennt. 
Die Identität des Benutzers wird als verschlüsselter Cookie gespeichert und von dort aus vollständig akzeptiert, was aus unserer Sicht ein Sicherheitsproblem darstellt, denn der Cookie ist ja auf dem System des Benutzers. 
Auch wenn es vielleicht kompliziert ist, ist es möglich, dass der Cookie früher oder später geknackt und mit alternativen Informationen befüllt wird. Uns ist daher unklar, wie die Sicherheit hier ernsthaft hergestellt wird.


