# inventario-POO

Restaurar los paquetes de NuGet sugeridos:
  -FontAwesome.Sharp


La base de datos usada es MySql: 

  CREATE DATABASE logins
  USE logins
  
  CREATE TABLE users (
  id int primary key auto_increment NOT NULL,
  user VARCHAR(45) NOT NULL,
  pass VARCHAR(45) NOT NULL,
  correo VARCHAR(45) NOT NULL
  )

  CREATE TABLE product (
  id_pro int primary key NOT NULL,
  producto varchar(45) NOT NULL,
  cantidad int NOT NULL,
  precio int NOT NULL
  )

  https://tse2.mm.bing.net/th?id=OIP.Le9R6zRgeOCZ4AW8tNJDwAHaEK&pid=Api&P=0&h=180
