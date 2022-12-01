# Cine

# Acciones
* Ingresar a la carpeta src
* Click derecho (abrir terminal integrado) en src
* Escribir "dotnet build" en la terminal 
* Debe mostrar "Compilación correcta."

* Ingresar a la carpeta Presentacion 
* Click derecho (abrir terminal integrado) en Presentacion
* Escribir "dotnet run" en la terminal
* Ingresar al localhost (ctrl + clic) en http://localhost:5029/swagger 

# Swagger
* Para poder correr el swagger hay que iniciar el servicio de base de datos (mysql), luego de esto ya pueden continuar con el programa
* POST: Funciona como un INSERT, todos los valores que daran de alta se ingresar en POST, al ingresar lo deberan corroborar en el GET.
* GET: Funciona como un SELECT, todos los valores de la tabla se mostraran en este apartado del programa Swagger
* PUT: Funciona como un UPDATE, con el id que arroja cada elemento de la tabla podras cambiar los valores en PUT, de nuevo se debera corroborar en el GET  para saber si los cambios fueron guardados
* DELETE: Con el id de los elementos de la tabla se podra eliminar los valores dados de alta anteriormente. 

* Al saber como funciona cada elemento del programa podemos proseguir a probar nuestros archivos. 
* Ejemplo: Entramos a POST para ingresar un valor en nombre, antes debemos oprimir el boton "TRY OUT" para que nos deje editar el valor luego de esto oprimimos el boton "EXECUTE". Vamos a GET a visualizar el cambio y efectivamente se habrá guardado el valor que ingresamos por el programa. 
Para cambiar este mismo valor deberemos recurrir a PUT donde oprimiremos TRY OUT Y luego EXECUTE donde con el id que nos arrojo en el GET, ese id lo vamos a copiar y pegar en el PUT luego nos dará la opción de cambiar el nombre y de nuevo corroborar el cambio en el GET.
Si deseamos borrar este cambios oprimimos DELETE, luego TRY OUT e ingresar el id de lo que queremos borrar, oprimimos execute y en el GET ya no se visualizara el valor eliminado. 

# ¿Como correr los test?
* Deberemos abrir un nuevo terminal y escribir "cd src" luego de esto tipeamos "DOTNET TEST" y esperamos a que nos arroje el resultado. 
* Deberiamos poder visualizar una ejecución correcta, con cero errores y todos los test superados. 

# Migraciones
* Para crear la base de datos en MySql se debe traducir desde nuestro contexto (C#) a SQL, para ello debemos realizar una migracion. Esto se debe realizar una unica vez al momento de crear la base de datos.
* Debemos tipear en el terminal intregrado el siguiente comando.

```
dotnet ef migrations add MigracionInicial --context PresentacionDbContext --output-dir Persistencia/Migraciones --project Presentacion --startup-project Presentacion
```

* Cada vez que ingresemos un nuevo cambio en el contexto. Por ejemplo agregar un nuevo atributo a una entidad. Se debe realizar una nueva migracion con un nombre distinto a los existentes.
```
dotnet ef migrations add UnNuevoCambio --context PresentacionDbContext --output-dir Persistencia/Migraciones --project Presentacion --startup-project Presentacion
```
