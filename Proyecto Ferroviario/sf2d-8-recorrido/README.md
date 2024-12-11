# SF2D - Simulador Ferroviario 2D 
---
### ÍNDICE:
* Introducción al proyecto
* [Organización](#organización)
    * [Patrón de diseño y tecnología](#patrón-de-diseño-y-tecnología)
    * [Repositorio](#repositorio)
    * [Configuracón del proyecto](#configuracón-del-proyecto)
* [Git y GitLab: Procedimiento y comandos útiles](#git-y-gitlab-procedimiento-y-comandos-útiles)
    * [El flujo de trabajo es sencillo:](#el-flujo-de-trabajo-es-sencillo)
    * [Comandos útiles y formas](#comandos-útiles-y-formas)
    * [Pull antes que Push](#pull-antes-que-push)
* [Merge Request](#merge-request)
* [Comentarios](#comentarios)
---
*Introducción al proyecto... (completar)*

---
### Organización

#### Patrón de diseño y tecnología

El patrón de diseño es Model-View-View Model -> **MVVM**. <br>
Usamos [.NET](https://learn.microsoft.com/en-us/dotnet/?view=net-9.0), [C#](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/) y [WPF](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/?view=netdesktop-9.0). Los links llevan a sus respectivas documentaciones.

#### Repositorio

Hay dos ramas: **`main`** y **`develop`**. <br>
**`main`** : será la Rama que tenga la mejor/más estable versión del simulador.<br>
**`develop`** : será donde vayamos desarrollando. Las Merge Request serán a esta Rama.

Los [**Issues**](https://gitlab.com/unla-development/sf2d/-/issues) será lo que usemos para determinar qué hacer y quién/es lo hacen.<br>
Algo genial de GitLab son sus [**Issue boards**](https://gitlab.com/unla-development/sf2d/-/boards), lo que nos va a permitir trabajar con los Issues de manera más visual y con el método KanBan.

Las [**Labels**](https://gitlab.com/unla-development/sf2d/-/labels) 
nos van a permitir categorizar las actividades por tipo:
* `Feature`: Todo desarrollo que agregue funcionalidad al proyecto.
* `Bug`: Toda corrección de error que haya surgido.
* `Repository`: Cambios al Repositorio.
* `En proceso`: Designada automáticamente por el Issue board, nos aclara qué Issues están siendo resueltos.

En los Issue Boards también están:
* `Open`: Defalut de GitLab; el Issue/tarea se está definiendo.
* `Closed`: Defalut de GitLab; el Issue/tarea finalizó.

#### Configuracón del proyecto

La organización del proyecto, carpetas y **namespaces** es la siguiente:

```
SF2D/
├── Resources/
│   └── # (Imagenes, archivos, etc. que utilice el simulador)
│
├── Model/
│   └── # (Clases de datos y de control) 
│    
├── ViewModel/
│   ├── # (Intermediario entre Movel y View)
│   ├── # (Todas los ViewModel heredan ViewModelBase)
│   └── ViewModelBase.cs
│
├── View/
│   ├── # (Todo lo que ve el usuario; no hay lógica de programa en code-behind)
│   ├── *.xaml
│   ├── *.xaml.cs (code-behind)
│   └── UserControls/  
│       ├── # (controles personalizados)
│       └── # (Hay una Clase específica que se llama UserControl)
│
└── Commands/
    └── # (Implementaciones de la interfaz ICommand)
```

Hay otros archivos que están en la carpeta raíz SF2D y que tienen su función.
```
SF2D/
├── App.xaml
├── App.xaml.cs
├── README.md (¡Esto que estás leyendo!)
├── .gitignore (Añadan cualquier archivo o carpeta que no sea parte del proyecto)
└── SF2D.csproj (Necesario para cargar el proyecto en Visual Studio)
```
---
### Git y GitLab: Procedimiento y comandos útiles

#### El flujo de trabajo es sencillo:
* Los `Issue` preceden cualquier actividad/desarrollo.
* Todo desarrollo tiene su propia Rama.
* El desarrollo termina con un Merge Request a la Rama `develop`.

#### Comandos útiles y formas

Como se dijo antes: **tiene** que haber un `Issue` que describa lo que van a hacer, quienes van a estar involucrados, etc.. Esto es así para poder rastrear qué Merge Request resuelve qué cosa.

Ya que clonar el repositorio de una te trae **`main`**, 
clonar la rama **`develop`** se hace con el siguiente comando: 
```
git clone -b develop https://gitlab.com/unla-development/sf2d.git
```

Antes de empezar a trabajar, creen una nueva Rama a partir de lo que clonaron antes. <br>
El nombre de la Rama va seguir el siguiente formato (noten que el guión va pegado al número):
```
<número-del-issue>-<lo-que-les-pinte>
// por ejemplo: el Issue de estas modificaciones es #5, entonces:
5-continuar-readme
```
Escribir el nombre así permite a GitLab linkear las Merge Request a ese `Issue` en particular, y darlos por terminados una vez se haga el Merge.

#### Pull antes que Push

Antes de mandar nada al Repositorio, siempre hay que hacer un Pull:
```
git pull origin <nombre-de-su-rama>
```
No se olviden de hacer un commit con todos sus cambios.

Ahora sí. Siempre que hagan un Push, hágalo en la Rama de su desarrollo:

```
git push origin <nombre-de-la-rama>
```
GitLab parece crear la Rama automáticamente en el Repositorio si la que ustedes Pushearon no existía antes.

### Merge Request

Las Merge Request son el punto de culminación de cualquier desarrollo, y su procedimiento es el siguiente:

* Una vez terminen de implementar algo, van a [Merge Request](https://gitlab.com/unla-development/sf2d/-/merge_requests) y crean una nueva Request.
* Seleccionan su Rama de desarrollo y la rama `develop`.
* Siempre dejen tildado **"Mark as a draft"**.
* Seleccionen al Reviewer que se encargue de revisar las Merge Request, así le notifica.
* Crean la Merge Request.

Esperen a recibir una devolución sobre su Request. Una vez veamos esté todo ok, se aprueba y se une a `develop`.

### Comentarios

Parece mucho texto pero en realidad es bastante fluido el procedimiento. Siempre que haya dudas lo charlamos entre nosotros y, no se olviden, esto lo armé para tener algo con que empezar a organizarnos. No está escrito en piedra y lo podemos ir mejorando con el tiempo.

Abrazo y a programar, beibi.

[Volver arriba ↑](#sf2d---simulador-ferroviario-2d)