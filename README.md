# Tautulli.NET

Implementation of the official Tautulli API for C#. The API is found [here](https://github.com/Tautulli/Tautulli/blob/master/API.md).

Example usage

```C#
Tautulli.Net.Tautulli tautulli = new Tautulli.Net.Tautulli("https://example.com", "apikey");
var libraries = await c.get_libraries();
```
