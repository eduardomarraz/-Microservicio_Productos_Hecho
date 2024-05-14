<h1>Proyecto .NET 6 con Microservicios para una web de gestión de productos</h1>
Una web desarrollada con .NET con ASP.NET Core: Razor pages, conectada a Azure
mediante un Bus de Mensajeria en el cual los email suscritos reciben la mensajería.
La base de datos esta en SQL Server y se accede a través de las peticiones de los
controladores. El uso de mediadores, Dtos y del patrón repositorio para obtener un nivel de
abstracción con una mayor seguridad para evitar que los componentes tengan un
acoplamiento fuerte, por eso el uso de inyectores de dependencias en la parte del
Program.cs para garantizar una funcionalidad aislada y mejorar la modularidad.
