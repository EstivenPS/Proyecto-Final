
# EPS Prestamos

![Logo](https://user-images.githubusercontent.com/54590857/69562467-9a2e1600-0f85-11ea-90d3-7fb05af524a4.jpg)

_EPS Prestamos es un sistema de prestamos de dinero en efectivo, el cual tiene como proposito optimizar, eficientizar y sistematizar algunos trabajos referentes a prestamos de dinero._

## ⌨️ Login 

![imagen](https://user-images.githubusercontent.com/54590857/69562663-04df5180-0f86-11ea-979c-3bf812692ec8.png)

_Esta es la primera ventana que se muestra al ejecutar el programa, se trata de un Login en el cual el usuario deberá loguearse para poder acceder al sistema. Si es la primera vez que se ejecuta el programa, existe un usuario creado por defecto con accesos de "Administrador/a", cuyo **Nombre de Usuario** y **Contraseña** son: **admin** y **admin** respectivamente._ 


## ⚙️ Menú 

![imagen](https://user-images.githubusercontent.com/54590857/69563516-a0bd8d00-0f87-11ea-9f57-006ac728654c.png)

_Esta es la ventana de menú en la cual podra desplazarse entre los diferentes registros, consultas y reportes._


## 📋 Registros 

### 📋 Registro de clientes 

![imagen](https://user-images.githubusercontent.com/54590857/69563872-5092fa80-0f88-11ea-943a-6023231f3740.png)

_Este es el registro de clientes, donde podrá agregar los clientes a los que se les podrán realizar prestamos. El "Estado" es para definir si el registro se encuentra activo o inactivo._

### 📋 Registro de cobradores 

![imagen](https://user-images.githubusercontent.com/54590857/69564832-1a567a80-0f8a-11ea-8cb1-eb4f0c29019e.png)

_Aquí se registran los cobradores que trabajan en la empresa y al igual que en el registro anterior se utiliza el atributo "Estado" para definir si el cobrador se encuentra activo o inactivo._

### 📋 Registro de prestamos 

![imagen](https://user-images.githubusercontent.com/54590857/69564321-3279ca00-0f89-11ea-9faa-1e54a86de3a2.png)

_En este registro se guardan los prestamos. El cliente y el cobrador se debe elegir en base a los que se hayan registrado en el sistema, también se debe definir la tasa de interés a la que se realizará el prestamo y para finalizar se debe dar clic al botón con la palomilla verde para que se calculen y se muestren las cuotas que tendrá el prestamo en base a los datos llenados anteriormente._

### 📋 Registro de cobros

![imagen](https://user-images.githubusercontent.com/54590857/69573437-76c29580-0f9c-11ea-8480-b4e08c48d725.png)

_Aquí se registran los cobros que se le realizaran a las cuotas de un prestamo en particular. Para ello se debe llenar en el siguiente orden: primero se debe elegir el cliente al que se le va a realizar el cobro, después se habilitará el campo "Prestamo Id" para elegir de entre los prestamos pertenecientes al cliente, aquél al que se le va a realizar el cobro, luego de esto se habilitará el campo "Número de cuota" para que elija el número de la cuota y automáticamente se va a habilitar el campo de "Monto", el cual sólo admite montos menores o iguales al balance de la cuota elegida previamente. También se tiene un botón con el cual se puede imprimir un recibo con algunos datos del cobro, como el que se muestra a continuación:._

![imagen](https://user-images.githubusercontent.com/54590857/69686732-00568e00-1097-11ea-9086-9356a27a7209.png)

### 📋 Registro de usuarios 

![imagen](https://user-images.githubusercontent.com/54590857/69565032-7e793e80-0f8a-11ea-84a0-30a3dd0727ab.png)

_Este es el registro de usuarios, a la hora de crear un usuario se debe elegir el tipo de usurio, de entre las posibles opciones están:_ 

* _**Administrador/a:** Este tiene acceso a todos los módulos del sistema y es el único capaz de crear nuevos usuarios y consultarlos._
* _**Secretario/a:** Este sólo tiene acceso a los siguiente módulos: Clientes, Cobradores, Prestamos y Cobros._
* _**Invitado/a:** Este sólo tiene acceso a los módulos de Prestamos y Cobros._

_Aquí también se usa el campo "Estado" para definir si el usuario esta activo o inactivo._


## 📋 Consultas 

![imagen](https://user-images.githubusercontent.com/54590857/69566042-92be3b00-0f8c-11ea-9b56-b6c15a961610.png)

_Todas las consultas funcionan de la misma manera, en estas se pueden realizar consultas específicas de los registros que se tengan guardados, también se permite filtrar por diversos campos así como también por un rango de fecha. Además de incluir un botón llamado "Imprimir" con el que podremos visualizar los registros consultados con anterioridad en un reporte como el siguiente:_

![imagen](https://user-images.githubusercontent.com/54590857/69566616-de251900-0f8d-11ea-8988-55a1dc42f5cd.png)

## 🔧 Requisitos 

_Debe contar con una computadora que tenga como mínimo las siguientes especificaciones:_

* Sistema operativo: Windows 10 (64 bits).
* Procesador: Intel(R) Core(TM) i3 a 1.9 GHz.
* Memoria RAM: 8 Gb. 
* Espacio en disco duro: 250 Gb.

## 🛠️ Construido con 

* Visual Studio C#.
* SQL Server.
* Photoshop CC (Para el logo de la empresa).
* Mozilla Firefox.

## ✒️ Autor 

_**Estiven de Jesus Padilla Santos (2017-0596).**_

## 🎁 Expresiones de Gratitud 

* Gracias a Dios por permitirme llegar hasta este punto de mi carrera y por darme las fuerzas y la sabiduría para cumplir con cada una de las asignaciones que se me encomendaban durante el semestre ✨.
* Gracias al profesor Enel por enseñarme todos los conocimientos requeridos para poder darle vida a este software 📚.
* Gracias a mis amigos por ayudarme en mis momentos de dudas 🤓. 
