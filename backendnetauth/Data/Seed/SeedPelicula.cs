using backendnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendnet.Data.Seed;

public class SeedPelicula : IEntityTypeConfiguration<Pelicula> {
    public void Configure(EntityTypeBuilder<Pelicula> builder) {
        builder.HasData(
            new Pelicula { PeliculaId = 1, Titulo = "Sueño de fuga", Sinopsis = "Andrew Dufresne es un hombre inocente que es acusado del asesinato de su mujer. Tras ser condenado a cadena perpetua, es enviado a la cárcel de Shawshank, en Maine. Con el paso de los años, Andrew conseguirá ganarse la confianza del director del centro y el respeto de los otros convictos, especialmente de Red, el jefe de la mafia." },
            new Pelicula { PeliculaId = 2, Titulo = "El padrino", Sinopsis = "Don Vito Corleone es el respetado y temido jefe de una de las cinco familias de la mafia de Nueva York en los años 40. El hombre tiene cuatro hijos: Connie, Sonny, Fredo y Michael, que no quiere saber nada de los negocios sucios de su padre. Cuando otro capo, Sollozzo, intenta asesinar a Corleone, empieza una cruenta lucha entre los distintos clanes." },
            new Pelicula { PeliculaId = 3, Titulo = "El caballero oscuro", Sinopsis = "Con la ayuda del teniente Jim Gordon y del Fiscal del Distrito Harvey Dent, Batman mantiene a raya el crimen organizado en Gotham. Todo cambia cuando aparece el Joker, un nuevo criminal que desencadena el caos y tiene aterrados a los ciudadanos." },
            new Pelicula { PeliculaId = 4, Titulo = "El retorno del rey", Sinopsis = "La batalla por la Tierra Media ha empezado. Las fuerzas de Saruman han sido destruidas y por primera vez parece que hay una pequeña esperanza. Sin embargo, el poder de Sauron crece y su interés se centra en Gondor, el último reducto de los hombres, cuyo heredero es Aragorn. Mientras, Frodo y Sam, guiados por Gollum, siguen su peligrosa misión a través de Mordor para destruir el anillo." },
            new Pelicula { PeliculaId = 5, Titulo = "Tiempos violentos", Sinopsis = "La vida de un boxeador, dos sicarios, la esposa de un gánster y dos bandidos se entrelaza en una historia de violencia y redención." },
            new Pelicula { PeliculaId = 6, Titulo = "Forrest Gump", Sinopsis = "Sentado en un banco en Savannah, Georgia, Forrest Gump espera al autobús. Mientras éste tarda en llegar, el joven cuenta su vida a las personas que se sientan a esperar con él. Aunque sufre un pequeño retraso mental, esto no le impide hacer cosas maravillosas. Sin entender del todo lo que sucede a su alrededor, Forrest toma partido en los eventos más importantes de la historia de los Estados Unidos." },
            new Pelicula { PeliculaId = 7, Titulo = "El club de la pelea", Sinopsis = "Un empleado de oficina insomne, harto de su vida, se cruza con un vendedor peculiar. Ambos crean un club de lucha clandestino como forma de terapia y, poco a poco, la organización crece y sus objetivos toman otro rumbo." },
            new Pelicula { PeliculaId = 8, Titulo = "Inception", Sinopsis = "Dom Cobb (Leonardo DiCaprio) es un ladrón con una extraña habilidad para entrar a los sueños de la gente y robarle los secretos de sus subconscientes. Su habilidad lo ha convertido en un atractivo en el mundo del espionaje corporativo, pero ha tenido un gran costo en la gente que ama. Cobb tiene la oportunidad de ser perdonado cuando recibe una tarea imposible: plantar una idea en la mente de una persona. Si tiene éxito, será el crimen perfecto, pero un enemigo se anticipa a sus movimientos." },
            new Pelicula { PeliculaId = 9, Titulo = "Star Wars: Episodio V - El imperio Contrataca", Sinopsis = "" },
            new Pelicula { PeliculaId = 10, Titulo = "Matrix", Sinopsis = "Son tiempos adversos para la rebelión. Aunque la Estrella de la Muerte ha sido destruida, las tropas imperiales han hecho salir a las fuerzas rebeldes de sus bases ocultas y los persiguen a través de la galaxia. Tras escapar de la terrible Flota Imperial, un grupo de guerreros de la libertad, encabezados por Luke Skywalker, ha establecido una nueva base secreta en el remonto mundo helado de Hoth." },
            new Pelicula { PeliculaId = 11, Titulo = "Interestelar", Sinopsis = "Un grupo de científicos y exploradores, encabezados por Cooper, se embarcan en un viaje espacial para encontrar un lugar con las condiciones necesarias para reemplazar a la Tierra y comenzar una nueva vida allí. La Tierra está llegando a su fin y este grupo necesita encontrar un planeta más allá de nuestra galaxia que garantice el futuro de la raza humana." },
            new Pelicula { PeliculaId = 12, Titulo = "Dune: Parte dos", Sinopsis = "Paul Atreides se une a Chani y a los Fremen mientras busca venganza contra los conspiradores que destruyeron a su familia. Paul se enfrenta a una elección entre el amor de su vida y el destino del universo, y debe evitar un futuro terrible." },
            new Pelicula { PeliculaId = 13, Titulo = "Terminator 2: El juicio final", Sinopsis = "Algunos años antes, un viajero del tiempo le reveló a la madre de John que su hijo sería el salvador de la humanidad. Cuando un nuevo androide mejorado llega del futuro para asesinar a John, un viejo modelo será enviado para protegerle." },
            new Pelicula { PeliculaId = 14, Titulo = "Volver al futuro", Sinopsis = "Doc vuelve a aparecer con una máquina del tiempo mucho más modernizada y le pide a Marty y a su novia que le acompañen al futuro. En el Hill Valley de 2015 deberán solucionar un problema con la ley que tendrá uno de los futuros hijos de Marty y Jenny. En el futuro, Biff Tannen roba la máquina del tiempo y vuelve al pasado para darle a su hijo un libro con estadísticas deportivas para poder ganar una enorme fortuna en las apuestas. Marty y Doc tendrán que parar la posible catástrofe del destino." },
            new Pelicula { PeliculaId = 15, Titulo = "Barbie", Sinopsis = "Después de ser expulsada de Barbieland por no ser una muñeca de aspecto perfecto, Barbie parte hacia el mundo humano para encontrar la verdadera felicidad." }
        );
    }
}