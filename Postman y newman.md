# Postman y newman

[TOCM]

[TOC]

## Tabla de contenido
- [Pruebas de servicios con Postman](#Pruebas-de-servicios-con-Postman).
- [Configuración Postman](#Configuración-Postman).
- [Ejecución automatizadas con Newman](#Ejecución-automatizada-con-Newman).

## Documentaciones

- **Documentación estrategias de ramificación:** [Estrategia de ramificacion](https://github.com/escobarjsa/ci-netcoreApi/blob/main/Estrategias%20de%20ramificacion.md)
- **Documentación del tablero de Azure DevOps:** [Tablero Azure DevOps](https://github.com/escobarjsa/ci-netcoreApi/blob/main/TableroAzureDevOps.md)
- **Documentación de Azure DevOps:** [Azure DevOps](https://github.com/escobarjsa/ci-netcoreApi/blob/main/README.md)
- **Documentación Postman y newman:** [Azure DevOps](https://github.com/escobarjsa/ci-netcoreApi/blob/main/Postman%20y%20newman.md)

### Pruebas de servicios con Postman

Los servicios que se usarán serán los de la clase Producto, en ellos se realizará un get, post, put y delete.

![](https://i.postimg.cc/dQfp4xxT/15.jpg)

### Configuración Postman

Con el la aplicación ya publicada en Azure, el siguiente paso es configurar postman.

- Configurar las colecciones: para configurar las colecciones en postman nos dirigimos a "Collections, click en el símbolo de "+" para una nueva colección, se le pone un nombre y  procede a agregar los request que se requieren.


![](https://i.postimg.cc/dtjyBzWq/2.jpg)

- Crear el ambiente de trabajo: para crear el ambiente de trabajo dar click en "Enviroments", agregar un nuevo ambiente de trabajo seleccionando el "+", ponerle un nombre y asignar las variables. Para este ejemplo las variables asignadas con el valor son:

| Variable      | Valor |
| --------- | -----|
| BasedURI  | https://tiendaapi.azurewebsites.net/|
| EndPoint   |/api|
| BasedProducto |Producto|

![](https://i.postimg.cc/QMFLSZJw/3.jpg)

- Crear los request: para crear los request, estando en "Collections", se despliega el menú y se selecciona "Add request".

![](https://i.postimg.cc/k5vSjLMN/4.jpg)

- Parámetros para el request: cuando se crea un nuevo request, es necesario seleccionar de que tipo es, si es get, post, put, delete, etc. Para el caso práctico del ejemplo ya definidas las variables de entorno y el tipo que será get, get por id, post y delete, se procede a agregar el response. Para el response se selecciona las variables dentro de corchetes dobles "{{}}", en el body seleccionamos raw y sera de tipo JSON, además se agrega el response body para hacer el llamado; también se agregaron unos test, los cuales serán, que el servicio responda 200 de estatus y que busque un atributo , en este caso será "televisor".

![](https://i.postimg.cc/BnxP6RFW/5.jpg)

![](https://i.postimg.cc/R0gFJmVY/6.jpg)

Se realiza el paso anterior para todos los request que se necesiten y los test que se quieran implementar. Por ultimo estos son los que se usaron para este ejemplo.

![](https://i.postimg.cc/v8g7rYxf/7.jpg)

Configurado todo se selecciona la colección y se ejecutan las pruebas de todos los request.

![](https://i.postimg.cc/pXMjKDHM/8.jpg)

En el siguiente apartado, se pedirá seleccionar los request que queremos probar, además del número de iteraciones, y el tipo de data si se tiene; ya teniendo todo configurado se presiona "Run".

![](https://i.postimg.cc/Yq74vM6p/9.jpg)

Una vez que corrió la colección saldrá el número de iteraciones que hizo del servicio y su status, que previamente se configuro en los test.

![](https://i.postimg.cc/8Cfky0RK/10.jpg)

Por ultimo postman ofrece una funcionalidad que se llama "Flows", aquí se puede aromatizar las ejecuciones, teniendo ya las colecciones creadas con sus respectivos request, solo es agregarlas y que muestre los datos en terminal.

![](https://i.postimg.cc/Bn1RR9zK/11.jpg)

Salida en terminal.

![](https://i.postimg.cc/W3Sy02dQ/12.jpg)

### Ejecución automatizadas con Newman


Para la ejecución de la colección mediante Newman se debe abrir la consola, dirigirse a la carpeta contenedora de los archivos, estando en la carpeta escribir el siguiente comando
`newman run namefile -e nameenviroment`, para efectos prácticos se utilizó el siguiente comando, `newman run PruebaNewMan.postman_collection.json -e TestApiNetCoreWeb.postman_environment.json newman`

![](https://i.postimg.cc/BvPDxNXs/13.jpg)

#### Reporte

Para la generar reportes, se debe instalar reportes html, en consola se debe poner la siguiente línea de comando `npm install newman-reporter-html`, una vez instalado se ejecuta la siguiente línea `newman run namefile -e nameenviroment -r html` para efectos prácticos se usó la línea de comandos `newman run PruebaNewMan.postman_collection.json -e TestApiNetCoreWeb.postman_environment.json newman -r html`

![](https://i.postimg.cc/nVX4ZFHM/14.jpg)
