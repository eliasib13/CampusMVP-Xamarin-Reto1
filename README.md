# CampusMVP-Xamarin-Reto1

Crea tu primera aplicación Xamarin.Forms desde cero. Será una aplicación muy sencilla con el objeto de asegurarnos de que tienes todo lo necesario listo y funcionando para trabajar, y también para que vayas familiarizándote con el entorno y a trabajar con Xamarin.

Para crearla deberás utilizar alguna de las plantillas disponibles para Xamarin.Forms en Visual Studio.

La aplicación deberá contar con una etiqueta y un botón. Al pulsar este último se aumentará un contador de clics (número de veces que el botón ha sido pulsado) y se mostrará en pantalla.

Además, deberás:
  1.  Añadir los paquetes NuGet necesarios al proyecto para poder utilizar el SDK de Azure en clientes móviles.
  2.  Inicializar el cliente Azure correspondiente al SDK en cada proyecto correspondiente a cada plataforma nativa
  
Para añadir soporte a un servicio Mobile App desde una aplicación Xamarin se debe añadir una referencia al paquete NuGet **Microsoft.Azure.Mobile.Client** en cada uno de los proyectos de la solución (proyectos nativo y a la PCL en caso de utilizarla).
