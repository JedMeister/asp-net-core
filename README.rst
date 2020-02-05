ASP .NET Core on Nginx
======================

.NET Core is the successor to the .NET Framework, it's free and open
source provided by Microsoft. `ASP.NET Core`_ is the .NET Core version of
ASP.NET: a web application framework for developing dynamic web pages
with C#.

This appliances includes all of the standard features in `TurnKey Core`_,
and on top of that

- ASP.NET Core (provided by upstream Microsoft debian repos)
- MariaDB install
- ASP.NET Example App in C#
    + Installed to /var/www/aspnetcore-src
    + Pre-compiled (published) app in /var/www/aspnetcore
    + `Pomelo MySQL/MariaDB backend`_ for EF Core
    + Example MariaDB with EF Core page
- SSL Support out of the box.
- Webmin modules configuring PHP and MySQL

Further reading:

`EF Core`_ (Entity Framework Core) is a powerful ORM, used in the
Turnkey Example App.

Credentials *(password set at first boot)*
------------------------------------------

- Webmin, SSH, MySQL: username **root**

.. _ASP.NET Core: https://docs.microsoft.com/en-us/aspnet
.. _Turnkey Core: https://www.turnkeylinux.org/core
.. _Pomelo MySQL/MariaDB backend: https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql
.. _EF Core: https://docs.microsoft.com/en-us/ef/core
