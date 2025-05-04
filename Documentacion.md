# Sprint 0 - Documentación del Proyecto

## Nombre del Proyecto
"BookHub" - Plataforma de intercambio y venta de libros usados

## Enunciado del Proyecto
Crear una aplicación web que permita a los usuarios vender, comprar e intercambiar libros usados en su ciudad. La plataforma facilitará el contacto entre vendedores y compradores, gestionando publicaciones, búsquedas y mensajes.

## Objetivos

Los objetivos para nuestro proyecto de Inventario de Instrumentos musicales

### Objetivo General
- Desarrollar una aplicación web para facilitar La investigacion y recoleccion de informacion de intrumentos
musicales que puedan ser categorizados y catalogados.

### Objetivos Específicos
- Permitir a los usuarios ingresar instruementos musicales para obtener informacion sobre ellos.
- Ofrecer un buscador claro y preciso de un catalogo de intrumentos musicales.
- Facilitar la comunicación entre usuarios sobre sus comentarios y experiencias sobre los instrumentos 
que seleccionen.
- Que los usuarios puedan obtener informacion historia y relevante de los instrumentos musicales que 
filtren en el buscador del programa.

## Alcance

### Incluye
- Registro y login de usuarios.
- Publicación de libros con fotos y descripciones.
- Búsqueda de libros por filtros.
- Mensajería entre usuarios.
- Gestión de perfiles de usuario.

### No incluye
- Integración de pagos en línea.
- Envíos físicos de libros (solo conexión entre usuarios).
- Sistema de reseñas o calificaciones.

## Investigación de Tecnologías

### ABP Framework

- Framework de desarrollo basado en DDD (Domain Driven Design) y arquitectura en capas.
- Ofrece plantillas listas para iniciar proyectos modulares en ASP.NET 9 y Angular.
- Facilita autenticación, autorización, auditoría, multi-tenancy, entre otros.

Como se crea un nuevo proyecto en ABP ?
Selecciona un tema relevante para luego plantear 
una pregunta guia para el proyecto. Se crea un grupo pequeno para asignar roles a cada miembro, 
luego define el producto final a crear para planificar actividades y asi mismo el cronograma para el proyecto. 
La sintaxis para poder crear el proyecto en ABP Framework es en linea de comandos aplicar abp new, 
siendo por defecto Acme.BookStore el nombre del proyecto en la planitlla predeterminada

¿Qué capas maneja (Application, Domain, Infrastructure, UI)?
Application: Presenta la logica de negocio y operaciones relacionadas con objetos de dominio, 
actuando como intermediario entre la capa de presentacion y la de dominio.
Domain: Los objetos de negocio y las reglas de estos. Es donde se aplica el diseno dirigido por DDD.
Infraestructura: Ofrece las acciones tecnicas generales y los lazos de dependencia necesarios 
para el funcionamiento de la aplicacion.
UI (User interface): Se basa en las interacciones del usuario y su comunicacion con el exterior.


### ASP.NET 9
- Última versión del framework web de Microsoft.
- Mayor rendimiento, mejoras en minimal APIs y soporte de contenedores.

¿Cómo ABP maneja las entidades y servicios?
Las entidades y servicios se manejan de forma que se 
utilice un enfoque modular y basado en convenciones. 
Proporciona herramientas para poder generar codigo, 
extender funcionalidades y facilitar la creacion de aplicaciones web y microservicios.

### Angular
- Framework frontend de Google para construir aplicaciones web SPA.
- Permite la integración sencilla con APIs REST.
- Modular y altamente escalable.

¿Cómo funciona la conexión entre backend (ASP.NET) y frontend (Angular)?
Se establece mayormente por medio de 
la creacion de una API RESTful en backend y el uso de esta 
misma por medio del front end para poder obtener y enviar datos.

## Primer Backlog (Historias de Usuario)

- **HU01**: Como usuario, quiero registrarme y crear un perfil, para poder utilizar la plataforma.
- **HU02**: Como usuario, quiero publicar un libro con foto y descripción, para ofrecerlo en venta o intercambio.
- **HU03**: Como usuario, quiero buscar libros por título o autor, para encontrar lo que necesito fácilmente.
- **HU04**: Como usuario, quiero enviar mensajes a otros usuarios, para coordinar la compra o intercambio de libros.
- **HU05**: Como usuario, quiero ver un historial de mis publicaciones y mensajes, para llevar control de mis actividades.