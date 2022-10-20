Proyecto Api REST .NET Core 3.1 y 5.0 con Pruebas Unitarias xUnit
para ejercicio de CD/CI con Git Lab Runner y GitLab Flow
(Recomendado usar Linux como Servidor del Runner CI/CD y con los SDK .NET Core 3.1 y 5.0 instalados)

## Instructivo.

1) Abrir el proyecto con VS Code para edicion del .gitlab-ci para efecto de los tags personalizados.
2) Hacerle un git init
3) Configurarle un origen remoto de repositorio con una instancia de GitLab en servidor y que tenga un Runner compartido.
4) Agregar todo con git add .
5) Hacer un primer commit con git commit -a -m "Primer commit"
6) Hacer la publicacion con git push.


Cumpliendo esas instrucciones se disparara el proceso de CI/CD del proyecto

NOTA: Agregar a la URL de la Api desplegada despues del puerto este path: /swagger/index.html

Ejemplo:

http://....:5000/swagger/index.html

Cambiar el usuario Docker Hub de registro de imagen (editar ficheros .gitlab-ci.yml y docker-compose.yml) que tiene el mio que es: pm44019 a otro ya autenticado o publico para hacer pull y push de la imagen en el proceso CI/CD. Mi cuenta Docker Hub esta ilimitada para imagen publica sin login y por seguridad no doy mis credenciales.

Bienvenido a Git Hub.